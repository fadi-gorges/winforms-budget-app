namespace dotnet_assignment_2.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Nominal { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; } = string.Empty;
        public TransactionType TransactionType { get; set; }

        public int UserId { get; set; }
        public int SubCategoryId { get; set; }

        public User User { get; set; } = null!;
        public SubCategory SubCategory { get; set; } = null!;
    }

    public enum TransactionType
    {
        Income,
        Expense
    }
}
