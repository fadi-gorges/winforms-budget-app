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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (transactionType == "Income")
                {
                    Transaction income = new Transaction(nominal, date, notes, user);
                    user.AddTransaction(income);
                }
                else
                {
                    Transaction expense = new Transaction(nominal, date, category, notes, user);
                    user.AddTransaction(expense);
                }
                MessageBox.Show("Transaction successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
