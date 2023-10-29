using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class SignUp : Form
    {
        // Constructor for the SignUp form
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

                // Check if any of the required input fields are empty
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                    throw new FormatException();

                try
                {
                    // Check for duplicate usernames and email addresses
                    if (User.UsernameExists(username)) 
                        throw new Exception("Username already exists! Please try again!");
                    if (User.EmailExists(email))
                        throw new Exception("Email already exists! Please try again!");
                    // Check password length
                    if (password.Length < 8)
                        throw new Exception("Password must be at least 8 characters! Please try again!");

                    // Create a User object with the provided data
                    User userData = new User()
                    {
                        Username = username,
                        Email = email,
                        Password = password,
                        FirstName = firstName,
                        LastName = lastName
                    };
                    int code = User.SendOTPCode(userData.Email);
                    // Display a message and open the OTPVerification form
                    MessageBox.Show("Please check your email's inbox!", "Email Verification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    OTPVerification otpVerficaton = new OTPVerification(userData, code);
                    otpVerficaton.ShowDialog();
                    otpVerficaton = null;
                    this.Show();
                    // Clear the textboxes after
                    usernameTxt.Clear();
                    emailTxt.Clear();
                    passwordTxt.Clear();
                    firstNameTxt.Clear();
                    lastNameTxt.Clear();
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
