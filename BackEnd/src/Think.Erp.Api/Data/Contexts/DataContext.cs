using Microsoft.EntityFrameworkCore;
using Think.Erp.Api.Domain.Entities;

namespace Think.Erp.Api.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Entity> Entities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntityConfiguration();

            base.OnModelCreating(modelBuilder);
        }

    }
}