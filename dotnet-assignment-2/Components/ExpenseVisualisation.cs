using dotnet_assignment_2.Database;
using dotnet_assignment_2.Models;
using System.Windows.Forms.DataVisualization.Charting;

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
                List<Category> categories = db.Transactions
                    .Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year && t.TransactionType == TransactionType.Expense)
                    .GroupBy(t => t.Category)
                    .Select(g => new Category
                    {
                        Name = g.Key,
                        Nominal = g.Sum(t => t.Nominal)
                    })
                    .ToList();

                expenseTbl.DataSource = categories;

                LoadPieChart(categories);
            }
        }

        private void LoadPieChart(List<Category> transactions)
        {
            chart1.Series[0].Points.Clear();
            foreach (Category c in transactions)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(c.Name, c.Nominal);
                point.Label = c.Name + "\n#PERCENT{P0}";
                chart1.Series[0].Points.Add(point);
            }
        }

        private struct Category
        {
            public string Name { get; set; }
            public double Nominal { get; set; }
        }
    }
}
