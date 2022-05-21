using Microsoft.EntityFrameworkCore;
using MySite.Models;
namespace MySite.Data
{
    public class CodingDbContext : DbContext
    {
        public DbSet<Project> Projects => Set<Project>();
        public CodingDbContext(DbContextOptions<CodingDbContext> options) : base(options) { }
    }
}