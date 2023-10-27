using dotnet_assignment_2.Database;
using dotnet_assignment_2.Models;
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTxt.Text.ToLower();
                string password = passwordTxt.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    throw new FormatException();
                User user = User.GetUser(username, password);
                if(user == null)
                    MessageBox.Show("Invalid input! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show($"Welcome back {user.FirstName} {user.LastName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Homepage homepage = new Homepage(user);
                    homepage.ShowDialog();
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("All input fields cannot be empty! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
