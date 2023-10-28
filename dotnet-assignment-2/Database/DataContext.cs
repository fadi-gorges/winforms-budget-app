using dotnet_assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_assignment_2.Database
{
    // This class represents the Entity Framework DbContext for your application, responsible for configuring and interacting with the database
    public class DataContext : DbContext
    {
        // DbSet properties represent tables in the database that can be queried
        public DbSet<User> Users { get; set; } = null!; // DbSet for the 'Users' table
        public DbSet<Transaction> Transactions { get; set; } = null!; // DbSet for the 'Transactions' table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database provider and connection with a file named 'database.db'
            optionsBuilder.UseSqlite("FileName=database.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
