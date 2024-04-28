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

<<<<<<< HEAD
        
=======
>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Planet>().ToTable("Planet"); 
            mb.Entity<Character>().ToTable("Character");
        }
    }
}
