using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTxt.Text.ToLower();
                string email = emailTxt.Text.ToLower();
                string password = passwordTxt.Text;
                string firstName = firstNameTxt.Text;
                string lastName = lastNameTxt.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                    throw new FormatException();
                try
                {
                    if(User.UsernameExists(username))
                        throw new Exception("Username already exists! Please try again!");
                    if (User.EmailExists(email))
                        throw new Exception("Email already exists! Please try again!");
                    if (password.Length < 8)
                        throw new Exception("Password must be at least 8 characters! Please try again!");
                    User user = new User(username, email, password, firstName, lastName);
                    MessageBox.Show("Account successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Homepage homepage = new Homepage(user);
                    homepage.ShowDialog();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("All input fields cannot be empty! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
