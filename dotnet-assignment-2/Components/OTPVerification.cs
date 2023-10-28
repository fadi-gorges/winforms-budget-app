using dotnet_assignment_2.Models;

namespace dotnet_assignment_2.Components
{
    public partial class OTPVerification : Form
    {
        private User userData; // Store user data received from the sign-up form
        private int otpCode; // Store the OTP code

        // Constructor for the OTPVerification form
        public OTPVerification(User user)
        {
            this.userData = user; // Store the user data
            InitializeComponent();
            this.otpCode = User.SendOTPCode(user.Email); // Generate and send an OTP code to the user's email
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int inputCode = Convert.ToInt32($"{codeTxt1.Text}{codeTxt2.Text}{codeTxt3.Text}{codeTxt4.Text}"); // Combine the four textboxes to get the input OTP code
                if (otpCode == inputCode)
                {
                    if (userData != null)
                    {
                        // Create a new user account using the provided data
                        User user = new User(userData.Username, userData.Email, userData.Password, userData.FirstName, userData.LastName);
                        MessageBox.Show("Account successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Homepage homepage = new Homepage(user);
                        homepage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User data not found! Please try filling up your data again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("OTP code does not match! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input must be a single digit only! Please try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResendOTPBtn_Click(object sender, EventArgs e)
        {
            this.otpCode = User.SendOTPCode(userData.Email);
            MessageBox.Show("Please check your email's inbox!", "Email Verification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void SignUpLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CodeTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOneDigit(codeTxt1, e);
        }
        private void CodeTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOneDigit(codeTxt2, e);
        }
        private void CodeTxt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOneDigit(codeTxt3, e);
        }
        private void CodeTxt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOneDigit(codeTxt4, e);
        }

        // Function to accept only one digit in the input textboxes
        private void AcceptOneDigit(TextBox codeTxt, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit (0-9) and if the TextBox already contains a digit
            if ((!char.IsDigit(e.KeyChar) || codeTxt.Text.Length >= 1) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the input
            }
        }
    }
}
