using dotnet_assignment_2.Database;
using System.ComponentModel.DataAnnotations;

namespace dotnet_assignment_2.Models
{
    public class Transaction
    {
        // Properties that represent transaction data for the database attributes
        [Required] public int Id { get; set; }
        [Required] public double Nominal { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public TransactionType TransactionType { get; set; } // Either Income or Expense
        public int UserId { get; set; }

        // Constructors
        public Transaction() { } // Default constructor
        public Transaction(int id, double nominal, DateTime date, string category, string notes, TransactionType transactionType, int UserId) // Constructor for creating a new transaction with provided information
        {
            this.Id = id;
            this.Nominal = nominal;
            this.Date = date;
            this.Category = category;
            this.Notes = notes;
            this.TransactionType = transactionType;
            this.UserId = UserId;
        }
        public Transaction(double nominal, DateTime date, string notes, User user) // Constructor for creating a new income transaction
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
        public Transaction(double nominal, DateTime date, string category, string notes, User user) // Constructor for creating a new expense transaction
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

        // Insert a new transaction to the database
        private void InsertNewTransaction()
        {
            using (var db = new DataContext())
            {
                db.Transactions.Add(this);
                db.SaveChanges();
            }
        }

        // Method to update the details of an existing transaction in the database
        public void UpdateTransactionDetails(double nominal, DateTime date, string category, string notes, TransactionType transactionType)
        {
            using (var db = new DataContext())
            {
                var transaction = db.Transactions.Where(t => t.Id == this.Id).FirstOrDefault();
                transaction.Nominal = nominal;
                transaction.Date = date;
                transaction.Category = category;
                transaction.Notes = notes;
                transaction.TransactionType = transactionType;
                db.SaveChanges();
            }
        }

        // Delete the transaction from the database
        public void DeleteTransaction()
        {
            var transaction = new Transaction() { Id = this.Id };
            using (var db = new DataContext())
            {
                db.Attach(transaction);
                db.Remove(transaction);
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
