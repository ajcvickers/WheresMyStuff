// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var context = new StuffContext())
{
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();

    await context.Customers
        .Include(e => e.Contact).ThenInclude(e => e.PrimaryAddress).ThenInclude(e => e.PrimaryPhone).ThenInclude(e => e.Country)
        .Include(e => e.Contact).ThenInclude(e => e.PrimaryAddress).ThenInclude(e => e.Country)
        .Include(e => e.Contact).ThenInclude(e => e.PrimaryPhone).ThenInclude(e => e.Country)
        .Include(e => e.Contact).ThenInclude(e => e.Addresses).ThenInclude(e => e.PrimaryPhone).ThenInclude(e => e.Country)
        .Include(e => e.Contact).ThenInclude(e => e.Addresses).ThenInclude(e => e.Country)
        .Include(e => e.Contact).ThenInclude(e => e.PhoneNumbers).ThenInclude(e => e.Country)
        .ToListAsync();
}