using dotnet_assignment_2.Database;
using System.ComponentModel.DataAnnotations;

namespace dotnet_assignment_2.Models
{
    public class Transaction
    {
        [Required] public int Id { get; set; }
        [Required] public double Nominal { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public TransactionType TransactionType { get; set; }
        public int UserId { get; set; }

        public Transaction() { }
        public Transaction(double nominal, DateTime date, string notes, User user)
        {
            this.Id = GenerateID();
            this.Nominal = nominal;
            this.Date = date;
            this.Category = "Income";
            this.Notes = notes;
            this.TransactionType = TransactionType.Income;
            this.UserId = user.Id;
            InsertNewTransaction();
        }
        public Transaction(double nominal, DateTime date, string category, string notes, User user)
        {
            this.Id = GenerateID();
            this.Nominal = nominal;
            this.Date = date;
            this.Category = category;
            this.Notes = notes;
            this.TransactionType = TransactionType.Expense;
            this.UserId = user.Id;
            InsertNewTransaction();
        }
        private void InsertNewTransaction()
        {
            using (var db = new DataContext())
            {
                db.Transactions.Add(this);
                db.SaveChanges();
            }
        }

        // Generate a unique transaction ID
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
        private static bool IdExists(int id)
        {
            try
            {
                using (var db = new DataContext())
                {
                    if (db.Transactions.Where(t => t.Id == id).ToList().Count > 0)
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
    public enum TransactionType
    {
        Income,
        Expense
    }
}
