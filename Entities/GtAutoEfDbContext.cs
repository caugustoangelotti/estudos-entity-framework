using Microsoft.EntityFrameworkCore;

namespace gtauto_api.Entities
{
    public class GtAutoEfDbContext : DbContext
    {
        public GtAutoEfDbContext(DbContextOptions<GtAutoEfDbContext> options)
            :base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}