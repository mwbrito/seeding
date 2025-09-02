using Microsoft.EntityFrameworkCore;
using SeedingExample.Models;

namespace SeedingExample.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=produtos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "Café", Preco = 10.5m },
                new Produto { Id = 2, Nome = "Chá", Preco = 8.0m },
                new Produto { Id = 3, Nome = "Leite", Preco = 5.5m }
            );
        }
    }
}
