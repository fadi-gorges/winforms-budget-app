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

        // This method is triggered when the value of the month picker control changes.
        private void FilterMonthPck_ValueChanged(object sender, EventArgs e)
        {
            LoadData(); // Re-load data when the selected month changes
        }

        // LoadData retrieves and displays expense data for the selected month.
        private void LoadData()
        {
            using (var db = new DataContext())
            {
                // Retrieve expense transactions for the selected month and year and group them by category, calculating the total for each category.
                List<Category> categories = db.Transactions
                    .Where(t => t.UserId == user.Id && t.Date.Month == filterMonthPck.Value.Month && t.Date.Year == filterMonthPck.Value.Year && t.TransactionType == TransactionType.Expense)
                    .GroupBy(t => t.Category)
                    .Select(g => new Category
                    {
                        Name = g.Key,
                        Nominal = g.Sum(t => t.Nominal)
                    })
                    .ToList();
                // Display the category-wise expense data in a data table.
                expenseTbl.DataSource = categories;
                // Load the pie chart with the expense data.
                LoadPieChart(categories);
            }
        }

        // LoadPieChart creates and populates the pie chart with expense data.
        private void LoadPieChart(List<Category> categories)
        {
            chart1.Series[0].Points.Clear();
            foreach (Category c in categories)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(c.Name, c.Nominal);
                point.Label = c.Name + "\n#PERCENT{P0}";
                chart1.Series[0].Points.Add(point);
            }
        }

        // A struct to represent a category with its name and total nominal value.
        private struct Category
        {
            public string Name { get; set; }
            public double Nominal { get; set; }
        }
    }
}
