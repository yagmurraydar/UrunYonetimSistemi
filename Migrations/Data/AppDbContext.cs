using Microsoft.EntityFrameworkCore;
using UrunYonetimSistemi.Models;

namespace UrunYonetimSistemi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = 1,
                    Username = "yagmur",
                    Password = "1234"
                }
                );
            modelBuilder.Entity<Product>().HasData(
      new Product { Id = 1, Name = "Laptop", Description = "Gaming Laptop", Price = 12000, Stock = 10, CreatedAt = new DateTime(2026, 3, 18, 0, 0, 0, DateTimeKind.Utc) },
      new Product { Id = 2, Name = "Mouse", Description = "Wireless Mouse", Price = 200, Stock = 50, CreatedAt = new DateTime(2026, 3, 18, 0, 0, 0, DateTimeKind.Utc) }
  );
        }
    }
}

