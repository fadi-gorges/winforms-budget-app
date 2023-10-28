using dotnet_assignment_2.Database;
using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class Homepage : Form
    {
        private User user;

        public Homepage(User user)
        {
            this.user = user;
            InitializeComponent();
            LoadTransactionTable();
        }

        // Triggered when the "Add Record" button is clicked, it opens the "AddRecordForm" for adding new transactions.
        private void AddRecordBtnAction(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordForm addRecordForm = new AddRecordForm(user);
            addRecordForm.ShowDialog();
            addRecordForm = null;
            this.Show();
            LoadTransactionTable();
        }

        // Triggered when the "Expense Visualization" button is clicked, it opens the "ExpenseVisualisation" form (expenses summary and pie chart).
        private void ExpenseVisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseVisualisation expenseVisualisation = new ExpenseVisualisation(user);
            expenseVisualisation.ShowDialog();
            expenseVisualisation = null;
            this.Show();
        }

        // Triggered when the "Net Cash Flow" button is clicked, it opens the "NetCashFlow" form (cash flow summary and pie chart).
        private void NetCashFlowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NetCashFlow netCashFlow = new NetCashFlow(user);
            netCashFlow.ShowDialog();
            netCashFlow = null;
            this.Show();
        }

        // Triggered when a row in the transaction table is clicked, it opens the "TransactionDetails" form for editing and deleting.
        private void TransactionTbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
            DataGridViewRow selectedRow = TransactionTbl.SelectedRows[0];
            Transaction transaction = new Transaction(Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString()), Convert.ToDouble(selectedRow.Cells["Nominal"].Value.ToString()), DateTime.Parse(selectedRow.Cells["Date"].Value.ToString()), selectedRow.Cells["Category"].Value.ToString(), selectedRow.Cells["Notes"].Value.ToString(), selectedRow.Cells["TransactionType"].Value.ToString() == "Income" ? Models.TransactionType.Income : Models.TransactionType.Expense, Convert.ToInt32(selectedRow.Cells["UserId"].Value.ToString()));
            TransactionDetails transactionDetails = new TransactionDetails(transaction);
            transactionDetails.ShowDialog();
            transactionDetails = null;
            this.Show();
            LoadTransactionTable();
        }

        // Triggered when the value of the month picker control changes, it updates the displayed transactions.
        private void FilterMonthPck_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactionTable();
        }

        // LoadTransactionTable fetches and displays transaction data based on the selected month and user.
        private void LoadTransactionTable()
        {
            using (var db = new DataContext())
            {
                // Retrieve and display user-specific transactions for the selected month.
                TransactionTbl.DataSource = db.Transactions
                    .Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year)
                    .OrderByDescending(t => t.Date)
                    .ToList();
                // Hide columns containing Id and UserId to keep them from the user interface.
                TransactionTbl.Columns["Id"].Visible = false;
                TransactionTbl.Columns["UserId"].Visible = false;
            }
        }
    }
}