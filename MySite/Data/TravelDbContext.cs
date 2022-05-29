using Microsoft.EntityFrameworkCore;
using MySite.Models;
namespace MySite.Data
{
    public class TravelDbContext : DbContext
    {
        public DbSet<Travel> Travels => Set<Travel>();
        public DbSet<SuggestedPlace> SuggestedPlaces => Set<SuggestedPlace>();
        public DbSet<Picture> Pictures => Set<Picture>();
        public TravelDbContext(DbContextOptions<TravelDbContext> options) 
            : base(options) { }
    }
}