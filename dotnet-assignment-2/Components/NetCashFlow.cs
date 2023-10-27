using dotnet_assignment_2.Database;
using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class NetCashFlow : Form
    {
        User user;
        public NetCashFlow(User user)
        {
            this.user = user;
            InitializeComponent();
            LoadData();
        }
        private void FilterMonthPck_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var db = new DataContext())
            {
                double income = db.Transactions.Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year && t.TransactionType == TransactionType.Income).Sum(t => t.Nominal);
                incomeTxt.Text = income > 0 ? income.ToString("#.##") : "0";
                double expense = db.Transactions.Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year && t.TransactionType == TransactionType.Expense).Sum(t => t.Nominal);
                expenseTxt.Text = expense > 0 ? expense.ToString("#.##") : "0";
                double netCash = (income - expense);
                netTxt.Text = netCash > 0 ? netCash.ToString("#.##") : "0";
            }
        }
    }
}
