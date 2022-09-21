using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirst
{
    public class ECommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }   
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JFVV9NF;Database=ECommerceDb;User Id=sa;Password=eymen123");
        }
    }
    //Entity
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    //Entity
    public class Order
    {
        public int OrderId { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
