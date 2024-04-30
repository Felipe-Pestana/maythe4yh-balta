using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Entities.JoinEntity;
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
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Planet>()
                .ToTable("Planet");

            mb.Entity<Movie>()
                .ToTable("Movie")
                .HasMany(c => c.Characters)
                .WithMany(m => m.Movies)
                .UsingEntity<MovieCharacter>(j =>
                {
                    j.ToTable("MovieCharacter");

                    j.HasOne<Movie>().WithMany().HasForeignKey("MoviesId");
                    j.HasOne<Character>().WithMany().HasForeignKey("CharacterId");
                });


            mb.Entity<Movie>()
                .HasMany(c => c.Planets)
                .WithMany(m => m.Movies)
                .UsingEntity<MoviePlanet>(j =>
                {
                    j.ToTable("MoviePlanet");

                    j.HasOne<Movie>().WithMany().HasForeignKey("MoviesId");
                    j.HasOne<Planet>().WithMany().HasForeignKey("PlanetId");
                });

            mb.Entity<Movie>()
                .HasMany(c => c.Starships)
                .WithMany(m => m.Movies)
                .UsingEntity<MovieStarship>(j =>
                {
                    j.ToTable("MovieStarship");

                    j.HasOne<Movie>().WithMany().HasForeignKey("MoviesId");
                    j.HasOne<Starship>().WithMany().HasForeignKey("StarshipId");
                });

            mb.Entity<Movie>()
                .HasMany(c => c.Vehicles)
                .WithMany(m => m.Movies)
                .UsingEntity<MovieVehicle>(j =>
                {
                    j.ToTable("MovieVehicle");

                    j.HasOne<Movie>().WithMany().HasForeignKey("MoviesId");
                    j.HasOne<Vehicle>().WithMany().HasForeignKey("VehicleId");
                });

            mb.Entity<Character>()
                .ToTable("Character");

            mb.Entity<Vehicle>()
                .ToTable("Vehicle");
        }
    }
}
