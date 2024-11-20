using Krwinka.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Krwinka.Infrastructure.Persistence;

internal class KrwinkaDbContext : DbContext
{
    internal DbSet<Person> Persons { get; set; }
    internal DbSet<Order> Orders { get; set; }
    internal DbSet<LabTest> Labtests { get; set; }

    public KrwinkaDbContext(DbContextOptions<KrwinkaDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().HasMany(o => o.LabTests);
        modelBuilder.Entity<Order>().HasOne(o => o.Person)
            .WithMany(p => p.Orders)
            .HasForeignKey(o => o.PersonId);
    }
}
