namespace dotnet_assignment_2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<SubCategory> SubCategories { get; set; } = null!;
    }
}
