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
            context.Database.Migrate(); // Ensure that the database is up-to-date by applying any pending migrations
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTxt.Text.ToLower();
                string password = passwordTxt.Text;
                // Check if either the username or password is empty
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    throw new FormatException();
                // Attempt to retrieve the user with the provided credentials
                User user = User.GetUser(username, password);
                // If no user is found, display an error message
                if (user == null)
                    MessageBox.Show("Invalid input! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // If a user is found, display a welcome message and navigate to the homepage
                else
                {
                    MessageBox.Show($"Welcome back {user.FirstName} {user.LastName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Homepage homepage = new Homepage(user);
                    homepage.ShowDialog();
                    homepage = null;
                    this.Show();
                    // Clear the input fields
                    usernameTxt.Clear();
                    passwordTxt.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("All input fields cannot be empty! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigate to the sign-up page
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
