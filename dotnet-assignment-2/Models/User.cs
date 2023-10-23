namespace dotnet_assignment_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public List<Transaction> Transactions { get; set; } = null!;

        /*
         * Validates user information 
         * Returns: string[] errors
         */
        public static string[] Validate(string username, string email, string password, string firstName, string lastName)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(username))
            {
                errors.Add("Username is required");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errors.Add("Email is required");
            }

            else if (!email.Contains("@"))
            {
                errors.Add("Email must be a valid email address");
            }

            if (password.Length < 8 || string.IsNullOrWhiteSpace(password))
            {
                errors.Add("Password must be at least 8 characters long");
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                errors.Add("First Name is required");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                errors.Add("Last Name is required");
            }

            return errors.ToArray();
        }
    }
}
