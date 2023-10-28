using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class AddRecordForm : Form
    {
        User user;

        public AddRecordForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        // Triggered when the "Save" button is clicked, it adds a new transaction based on user input.
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string transactionType = transactionTypeCmb.Text;
                string category = categoryCmb.Text;
                DateTime date = datePckr.Value;
                string notes = notesTxt.Text;
                double nominal = Convert.ToDouble(nominalTxt.Text);
                if (transactionType.Length <= 0 || (transactionType == "Expense" && category.Length <= 0))
                    throw new FormatException();
                // Create a new income transaction and add it to the database.
                if (transactionType == "Income")
                {
                    Transaction income = new Transaction(nominal, date, notes, user);
                }
                // Create a new expense transaction and add it to the database.
                else
                {
                    Transaction expense = new Transaction(nominal, date, category, notes, user);
                }
                MessageBox.Show("Transaction successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Triggered when a key is pressed in the "Nominal" text box, it only allows digits, Backspace, and Delete key.
        private void NominalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit (0-9), the Backspace key, or the Delete key.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block input if it's not a digit or control key.
            }
        }

        // Triggered when the text in the "Transaction Type" combo box changes, it enables/disables the "Category" combo box.
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
