using MySite.Models;
using Microsoft.EntityFrameworkCore;
namespace MySite.Data
{
    public class PicturesDbContext : DbContext
    {
        public DbSet<Picture> Pictures => Set<Picture>();
        public PicturesDbContext(DbContextOptions<PicturesDbContext> options) 
            : base(options) { }
    }
}