using dotnet_assignment_2.Database;
using Microsoft.EntityFrameworkCore;

namespace dotnet_assignment_2.Components
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            using DataContext context = new DataContext();
            context.Database.Migrate();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
