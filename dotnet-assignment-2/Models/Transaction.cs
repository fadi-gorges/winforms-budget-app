using System.ComponentModel.DataAnnotations;

namespace dotnet_assignment_2.Models
{
    public class Transaction
    {
        [Required] public int Id { get; set; }
        [Required] public double Nominal { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Notes { get; set; } = string.Empty;
        public TransactionType TransactionType { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        
        public Transaction() { }
        public Transaction(double nominal, DateTime date, string notes, User user)
        {
            this.Nominal = nominal;
            this.Date = date;
            this.Notes = notes;
            this.User = user;
        }

        public static int GenerateID()
        {
            Random random = new Random();
            int randomNumber;
            do
                randomNumber = random.Next(10000000, 100000000);
            while (IdExists(randomNumber + ""));
            return randomNumber;
        }
        // Check if a user ID already exists
        private static bool IdExists(string id)
        {
            try
            {
                string[] data = File.ReadAllLines("transaction.txt"); // Read all lines from the user database file
                try
                {
                    foreach (string temp in data) // Iterate through each line in the file
                    {
                        string[] x = temp.Split(';'); // Split the line into fields using ';' as the separator
                        if (x[0] == id) // Check if the first field (ID) matches the provided ID
                            return true;
                    }
                    return false; // If no matching ID is found, return false
                }
                catch (IndexOutOfRangeException)
                {
                    return false; // Indicate an issue, as the database format is incorrect
                }
            }
            catch (FileNotFoundException)
            {
                return false; // Indicate an issue, as the database file is missing
            }
        }
    }

    public enum TransactionType
    {
        Income,
        Expense
    }
}
