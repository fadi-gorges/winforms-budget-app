using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class TransactionDetails : Form
    {
        private Transaction transaction;

        // Constructor for the TransactionDetails form
        public TransactionDetails(Transaction transaction)
        {
            this.transaction = transaction;
            InitializeComponent();
            LoadData();
        }

        // Load data from the provided transaction into the input fields
        private void LoadData()
        {
            if (transaction != null)
            {
                nominalTxt.Text = transaction.Nominal.ToString("#.##"); // Format 2 decimal places
                transactionTypeCmb.Text = transaction.TransactionType.ToString();
                categoryCmb.Text = transaction.Category.ToString();
                datePckr.Value = transaction.Date;
                notesTxt.Text = transaction.Notes.ToString();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string transactionType = transactionTypeCmb.Text;
                string category = transactionType == "Income" ? "Income" : categoryCmb.Text;
                DateTime date = datePckr.Value;
                string notes = notesTxt.Text;
                double nominal = Convert.ToDouble(nominalTxt.Text);

                // Validate input
                if (transactionType.Length <= 0 || (transactionType == "Expense" && category.Length <= 0))
                    throw new FormatException();

                if (nominal <= 0)
                {
                    MessageBox.Show("Nominal must be greater than 0", "Input Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Update transaction details in the database
                transaction.UpdateTransactionDetails(nominal, date, category, notes, (transactionType == "Income" ? TransactionType.Income : TransactionType.Expense));

                // Display a success message and close the form
                MessageBox.Show("Transaction successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException) // Display an error message for invalid input
            {
                MessageBox.Show("Invalid input. Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this transaction?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                // Delete the transaction from the database
                transaction.DeleteTransaction();
                // Display a success message and close the form
                MessageBox.Show("Transaction successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler to restrict input in the "Nominal" textbox to digits and decimal point
        private void NominalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit (0-9), the Backspace key, or the Delete key.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block input if it's not a digit or control key.
            }
        }

        // Event handler for the "TransactionType" combo box selection change
        private void TransactionTypeCmb_TextChanged(object sender, EventArgs e)
        {
            string transactionType = transactionTypeCmb.Text;
            if (transactionType == "Expense")
            {
                categoryCmb.Enabled = true;
            }
            else
            {
                categoryCmb.Enabled = false;
                categoryCmb.SelectedIndex = -1;
            }
        }
    }
}
