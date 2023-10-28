using dotnet_assignment_2.Database;
using System.ComponentModel.DataAnnotations;

namespace dotnet_assignment_2.Models
{
    public class User
    {
        [Required] public int Id { get; set; }
        [Required] public string Username { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string Password { get; set; } = string.Empty;
        [Required] public string FirstName { get; set; } = string.Empty;
        [Required] public string LastName { get; set; } = string.Empty;

        public User() { }
        public User(string username, string email, string password, string firstName, string lastName)
        {
            this.Id = GenerateID();
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            InsertNewUser();
        }

        private void InsertNewUser()
        {
            using(var db = new DataContext())
            {
                db.Users.Add(this);
                db.SaveChanges();
            }
        }

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

        // Generate a unique user id
        public static int GenerateID()
        {
            Random random = new Random();
            int randomNumber;
            do
                randomNumber = random.Next(10000000, 100000000);
            while (IdExists(randomNumber));
            return randomNumber;
        }
        
        // Check if a user ID already exists
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
        
        // Check if username already exists
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
        
        // Check if email already exists
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
    }
}
