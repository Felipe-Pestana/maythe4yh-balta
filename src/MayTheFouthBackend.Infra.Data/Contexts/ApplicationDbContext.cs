using MayTheFouthBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Planet>()
                .ToTable("Planet"); 

            mb.Entity<Movie>()
                .ToTable("Movie"); 

            mb.Entity<Character>()
                .ToTable("Character")
                .Property(x=>x.BirthYear)
                .HasColumnName("Birth_year");
            mb.Entity<Character>()
                .Property(x => x.PlanetId)
                .HasColumnName("Id_planet"); 

            mb.Entity<Vehicle>()
                .ToTable("Vehicle")
                .Property(x=>x.CostInCredits)
                .HasColumnName("cost_in_credits");
        }
    }
}
