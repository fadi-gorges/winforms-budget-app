using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class TransactionDetails : Form
    {
        private Transaction transaction;
        public TransactionDetails(Transaction transaction)
        {
            this.transaction = transaction;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            if (transaction != null)
            {
                nominalTxt.Text = transaction.Nominal.ToString("#.##");
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
                string category = categoryCmb.Text;
                DateTime date = datePckr.Value;
                string notes = notesTxt.Text;
                double nominal = Convert.ToDouble(nominalTxt.Text);
                if (transactionType.Length <= 0 || (transactionType == "Expense" && category.Length <= 0))
                    throw new FormatException();
                transaction.UpdateTransactionDetails(nominal, date, category, notes, transactionType == "Income" ? TransactionType.Income : TransactionType.Expense);
                MessageBox.Show("Transaction successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this transaction?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                transaction.DeleteTransaction();
                MessageBox.Show("Transaction successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NominalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit (0-9), the Backspace key, or the Delete key.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block input if it's not a digit or control key.
            }
        }

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
