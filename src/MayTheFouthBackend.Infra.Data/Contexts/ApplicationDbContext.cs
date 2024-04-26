using MayTheFouthBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
<<<<<<< HEAD:src/MayTheFouthBackend.Infra.Data/Contexts/ApplicationDbContext.cs
=======
        public DbSet<Planet> Planets { get; set; }
>>>>>>> 3ad735c7c1d5dbd080b1f791f799d197f3054331:src/MayTheFouthBackend.Infra.Data/Contexts/ApplicationContext.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

<<<<<<< HEAD:src/MayTheFouthBackend.Infra.Data/Contexts/ApplicationDbContext.cs
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Character> Character { get; set; }

        
=======
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Planet>().ToTable("Planet"); 
        }
>>>>>>> 3ad735c7c1d5dbd080b1f791f799d197f3054331:src/MayTheFouthBackend.Infra.Data/Contexts/ApplicationContext.cs
    }
}
