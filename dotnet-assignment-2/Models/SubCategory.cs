namespace dotnet_assignment_2.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Transaction> Transactions { get; set; } = null!;
    }
}
