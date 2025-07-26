using Microsoft.EntityFrameworkCore;
using summa_backend.Models;

namespace summa_backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Optional: seed initial admin user
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "admin", Password = "admin" }
        );
    }
}