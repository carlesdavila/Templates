using ApplicationFramework.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Domain.Entities;

namespace ServiceTemplate._1.Application.Interfaces;

public interface IServiceTemplate__1DbContext : IDbContext
{
    DbSet<User> Users { get; set; }
}
