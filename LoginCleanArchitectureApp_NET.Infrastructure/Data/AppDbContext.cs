using LoginCleanArchitectureApp_NET.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoginCleanArchitectureApp_NET.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
