using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab4.Models;

namespace Lab4.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<City>? Cities { get; set; }
    public DbSet<Province>? Provinces { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
   
        modelBuilder.Entity<City>().HasData(SampleData.GetCities());
        modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
    }
}
