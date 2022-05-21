using Microsoft.EntityFrameworkCore;
using MySite.Models;
namespace MySite.Data
{
    public class CookingDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredients => Set<Ingredient>();
        public DbSet<Recipe> Recipes => Set<Recipe>();
        public DbSet<LinkRecIng> RecipeIngredient => Set<LinkRecIng>();
        public CookingDbContext(DbContextOptions<CookingDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LinkRecIng>()
                .HasKey(l => new { l.RecipeId, l.IngredientId });

            modelBuilder.Entity<LinkRecIng>()
                .HasOne(l => l.Recipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(l => l.RecipeId);

            modelBuilder.Entity<LinkRecIng>()
                .HasOne(l => l.Ingredient)
                .WithMany(i => i.Recipes)
                .HasForeignKey(l => l.IngredientId);
        }
    }
}