using Microsoft.EntityFrameworkCore;
using MySite.Models;

namespace MySite.Data
{
    public class MindDbContext : DbContext
    {
        public DbSet<RandomPage> Pages => Set<RandomPage>();
        public MindDbContext(DbContextOptions<MindDbContext> options) : base(options) { }
    }
}
