using MayTheFouthBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Planet>().ToTable("Planet"); 
        }
    }
}
