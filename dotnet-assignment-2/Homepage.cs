using dotnet_assignment_2;

namespace _31927_Assignment_2
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void AddRecordBtnAction(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordForm addRecordForm = new AddRecordForm();
            addRecordForm.ShowDialog();
            addRecordForm = null;
            this.Show();
        }

        private void AccountListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ExpenseVisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpenseVisualisation expenseVisualisation = new ExpenseVisualisation();
            expenseVisualisation.ShowDialog();
            expenseVisualisation = null;
            this.Show();
        }

        private void NetCashFlowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NetCashFlow netCashFlow = new NetCashFlow();
            netCashFlow.ShowDialog();
            netCashFlow = null;
            this.Show();
        }
    }
}