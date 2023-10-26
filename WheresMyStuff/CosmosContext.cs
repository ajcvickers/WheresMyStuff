using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class CosmosContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseCosmos("https://localhost:8081", UserSecrets.Read("CosmosKey"), "CustomerDb")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);

    public DbSet<Customer> Customers => Set<Customer>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>();
    }
}