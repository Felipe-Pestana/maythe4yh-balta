using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories
{
    public class StarshipRepository :BaseRepository<Starship>, IStarshipRepository
    {
        public StarshipRepository(ApplicationDbContext context) : base(context) { }
    }
}
