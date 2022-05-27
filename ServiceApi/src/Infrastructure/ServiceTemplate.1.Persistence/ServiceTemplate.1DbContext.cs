using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Domain.Entities;
using ServiceTemplate._1.Application.Interfaces;

namespace ServiceTemplate._1.Persistence;

public class ServiceTemplate__1DbContext : DbContext, IServiceTemplate__1DbContext
{
    public ServiceTemplate__1DbContext(DbContextOptions<ServiceTemplate__1DbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseIdentityColumns();
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
