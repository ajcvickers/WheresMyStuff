using Microsoft.EntityFrameworkCore;

using (var context = new SqlServerContext())
{
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();

    context.Add(SampleData.CreateSampleCustomer());
    await context.SaveChangesAsync();
}
