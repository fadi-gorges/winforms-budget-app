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

        private void AddRecordBtnAction(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordForm addRecordForm = new AddRecordForm(user);
            addRecordForm.ShowDialog();
            addRecordForm = null;
            this.Show();
            LoadTransactionTable();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ExpenseVisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseVisualisation expenseVisualisation = new ExpenseVisualisation(user);
            expenseVisualisation.ShowDialog();
            expenseVisualisation = null;
            this.Show();
        }

        private void NetCashFlowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NetCashFlow netCashFlow = new NetCashFlow(user);
            netCashFlow.ShowDialog();
            netCashFlow = null;
            this.Show();
        }
        private void TransactionTbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
            DataGridViewRow selectedRow = TransactionTbl.SelectedRows[0];
            Transaction transaction = new Transaction(Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString()), Convert.ToDouble(selectedRow.Cells["Nominal"].Value.ToString()), DateTime.Parse(selectedRow.Cells["Date"].Value.ToString()), selectedRow.Cells["Category"].Value.ToString(), selectedRow.Cells["Notes"].Value.ToString(), selectedRow.Cells["TransactionType"].Value.ToString() == "Income" ? TransactionType.Income : TransactionType.Expense, Convert.ToInt32(selectedRow.Cells["UserId"].Value.ToString()));
            TransactionDetails transactionDetails = new TransactionDetails(transaction);
            transactionDetails.ShowDialog();
            transactionDetails = null;
            this.Show();
            LoadTransactionTable();
        }
        private void FilterMonthPck_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactionTable();
        }
        private void LoadTransactionTable()
        {
            using (var db = new DataContext())
            {
                TransactionTbl.DataSource = db.Transactions.Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year).OrderByDescending(t => t.Date).ToList();
                TransactionTbl.Columns["Id"].Visible = false;
                TransactionTbl.Columns["UserId"].Visible = false;
            }
        }
    }
}