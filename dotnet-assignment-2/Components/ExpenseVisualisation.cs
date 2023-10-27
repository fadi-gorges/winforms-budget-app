using dotnet_assignment_2.Database;
using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class ExpenseVisualisation : Form
    {
        private User user;
        public ExpenseVisualisation(User user)
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
                expenseTbl.DataSource = db.Transactions
                    .Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year && t.TransactionType == TransactionType.Expense)
                    .GroupBy(t => t.Category)
                    .Select(g => new
                    {
                        Category = g.Key,
                        Nominal = g.Sum(t => t.Nominal)
                    })
                    .ToList();
            }
        }
    }
}
