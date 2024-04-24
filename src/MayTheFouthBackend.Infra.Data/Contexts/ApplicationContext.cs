using MayTheFouthBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        {
        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Character> Character { get; set; }

        
    }
}
