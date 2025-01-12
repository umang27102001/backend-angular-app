using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using backend.Abstraction.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Product> products {get; set;}
        public DbSet<Category> categories { get; set; }
        public DbSet<User> users {get; set;}
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
    new Category { Id = 1, Name = "Electronics" },
    new Category { Id = 2, Name = "Books" },
    new Category { Id = 3, Name = "Clothing" },
    new Category { Id = 4, Name = "Home Appliances" },
    new Category { Id = 5, Name = "Toys" }
);

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                Enumerable.Range(1, 20).Select(i => new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description of Product {i}",
                    ProductCode = $"P{i:000}",
                    CategoryId = (i % 5) + 1, // Assign category in a round-robin fashion
                    Price = 100 + i,
                    Discount = 5 * (i % 3), // Random discounts
                    ImageUrl = $"https://example.com/product{i}.jpg"
                }).ToArray()
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Alice", Email = "alice@example.com", Password = "password1", Contact = "1234567890", Address = "123 Street, City" },
                new User { Id = 2, Name = "Bob", Email = "bob@example.com", Password = "password2", Contact = "1234567891", Address = "456 Avenue, City" },
                new User { Id = 3, Name = "Charlie", Email = "charlie@example.com", Password = "password3", Contact = "1234567892", Address = "789 Boulevard, City" },
                new User { Id = 4, Name = "David", Email = "david@example.com", Password = "password4", Contact = "1234567893", Address = "101 Main St, City" },
                new User { Id = 5, Name = "Eve", Email = "eve@example.com", Password = "password5", Contact = "1234567894", Address = "202 Elm St, City" }
            );
        }
    }
}
