using dotnet_assignment_2.Database;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;

namespace dotnet_assignment_2.Models
{
    public class User
    {
        // Properties that represent user data for the database attributes
        [Required] public int Id { get; set; }
        [Required] public string Username { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string Password { get; set; } = string.Empty;
        [Required] public string FirstName { get; set; } = string.Empty;
        [Required] public string LastName { get; set; } = string.Empty;

        // Constructors
        public User() { } // Default constructor
        public User(string username, string email, string password, string firstName, string lastName) // Constructor for creating a new user with provided information
        {
            this.Id = GenerateID();
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            InsertNewUser();
        }

        // Method to insert a new user into the database
        private void InsertNewUser()
        {
            using(var db = new DataContext())
            {
                db.Users.Add(this);
                db.SaveChanges();
            }
        }

        // Method to retrieve a user by username and password
        public static User GetUser(string username, string password)
        {
            try
            {
                using (var db = new DataContext())
                {
                    return db.Users.Where(u => (u.Username == username.ToLower() || u.Email == username.ToLower()) && u.Password == password).ToList()[0];
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Method to generate a unique user ID
        public static int GenerateID()
        {
            Random random = new Random();
            int randomNumber;
            do
                randomNumber = random.Next(10000000, 100000000);
            while (IdExists(randomNumber));
            return randomNumber;
        }

        // Method to check if a user ID already exists
        public static bool IdExists(int id)
        {
            try
            {
                using (var db = new DataContext())
                {
                    if (db.Users.Where(u => u.Id == id).ToList().Count > 0)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method to check if a username already exists
        public static bool UsernameExists(string username)
        {
            try
            {
                using (var db = new DataContext())
                {
                    if (db.Users.Where(u => u.Username == username.ToLower()).ToList().Count > 0)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false; 
            }
        }

        // Method to check if an email address already exists
        public static bool EmailExists(string email)
        {
            try
            {
                using (var db = new DataContext())
                {
                    if (db.Users.Where(u => u.Email == email.ToLower()).ToList().Count > 0)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method to send an OTP (One-Time Password) code to a user's email
        public static int SendOTPCode(string email)
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);
            string subject = ".Net Budgeting App Email Verification";
            string body = $"Please enter the following code to the provided fields within the application form. OTP Code: {randomNumber}";
            SendEmail(subject, body, email);
            return randomNumber;
        }

        // Method to send an email with the OTP code
        private static void SendEmail(string subject, string body, string email)
        {
            // Email Content Set Up
            MailMessage mailMessage = new MailMessage(); // Create a new instance of the MailMessage class to compose the email
            mailMessage.From = new MailAddress("dvnnyemail@gmail.com"); // Set the sender's email address
            mailMessage.To.Add(email); // Add the recipient's email address
            mailMessage.Subject = subject; // Set the email subject
            mailMessage.Body = body; // Set the email body

            // SMTP Set Up
            SmtpClient smtpClient = new SmtpClient(); // Create a new instance of the SmtpClient class to send the email
            smtpClient.Host = "smtp.gmail.com"; // Set the SMTP server host
            smtpClient.Port = 587; // Set the SMTP server port
            smtpClient.UseDefaultCredentials = false; // Specify that default credentials should not be used
            smtpClient.Credentials = new NetworkCredential("dvnnyemail@gmail.com", "nqin suqc hrrd cxir"); // Set the SMTP client's credentials (sender's email and password)
            smtpClient.EnableSsl = true; // Enable SSL encryption for secure email transmission

            smtpClient.Send(mailMessage); // Send the email
        }
    }
}
