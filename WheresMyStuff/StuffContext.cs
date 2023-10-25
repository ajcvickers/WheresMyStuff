using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

#pragma warning disable CS0169
public class StuffContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer($"Data Source=localhost;Database=ConfDemo;user=sa;password={UserSecrets.Read("SqlPassword")};TrustServerCertificate=true")
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);

    public DbSet<Customer> Customers => Set<Customer>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().OwnsOne(e => e.Contact,
            e =>
            {
                e.ToJson();
                e.OwnsOne(e => e.PrimaryAddress, e =>
                {
                    e.OwnsOne(e => e.PrimaryPhone).OwnsOne(e => e.Country);
                    e.OwnsOne(e => e.Country);
                });
                e.OwnsMany(e => e.Addresses, e =>
                {
                    e.OwnsOne(e => e.PrimaryPhone).OwnsOne(e => e.Country);
                    e.OwnsOne(e => e.Country);
                });
                e.OwnsOne(e => e.PrimaryPhone).OwnsOne(e => e.Country);;
                e.OwnsMany(e => e.PhoneNumbers).OwnsOne(e => e.Country);;
            });
    }
}

public class Customer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required ContactInfo Contact { get; set; }
}

public class ContactInfo
{
    public PhoneNumber? PrimaryPhone { get; set; }
    public required Address PrimaryAddress { get; set; }
    public List<PhoneNumber> PhoneNumbers { get; } = new();
    public List<Address> Addresses { get; } = new();
}

public class Address
{
    public required string Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Line3 { get; set; }
    public required string City { get; set; }
    public required Country Country { get; set; }
    public PhoneNumber? PrimaryPhone { get; set; }
}

public class PhoneNumber
{
    public required Country Country { get; set; }
    public required string Number { get; set; }
}

public class Country
{
    public required string FullName { get; set; }
    public required string ShortName { get; set; }
    public required int CountryCode { get; set; }
}
