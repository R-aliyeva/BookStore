using Microsoft.EntityFrameworkCore;
using BookStore.Domain.Entities;
namespace BookStore.Infrastructure.EfCore.DataContext;

public class AppDbContext:DbContext
{
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Customer>Customers { get; set; } = null!;
    public DbSet<Genre>Genres { get; set; }=null!;
    public DbSet<Order>Orders { get; set; } = null!;
    public DbSet<OrderDetails> OrderDetails { get; set; }=null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=BookStore1;Trusted_Connection=true;TrustServerCertificate=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Book>()
            .Property(b => b.Price)
            .HasPrecision(18, 2);

        base.OnModelCreating(modelBuilder);
    }
}
