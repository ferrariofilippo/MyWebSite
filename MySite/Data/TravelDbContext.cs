using Microsoft.EntityFrameworkCore;
using MySite.Models;
namespace MySite.Data
{
    public class TravelDbContext : DbContext
    {
        public DbSet<Travel> Travels => Set<Travel>();
        public DbSet<SuggestedPlace> SuggestedPlaces => Set<SuggestedPlace>();
        public TravelDbContext(DbContextOptions<TravelDbContext> options) 
            : base(options) { }
    }
}