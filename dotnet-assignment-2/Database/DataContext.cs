using dotnet_assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_assignment_2.Database
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=database.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<SubCategory> SubCategories { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
    }
}
