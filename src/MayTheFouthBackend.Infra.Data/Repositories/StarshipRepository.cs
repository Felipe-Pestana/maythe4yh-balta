using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class StarshipRepository : BaseRepository<Starship>, IStarshipRepository
{
<<<<<<< HEAD
    public class StarshipRepository :BaseRepository<Starship>, IStarshipRepository
    {
        public StarshipRepository(ApplicationDbContext context) : base(context) { }
    }
=======
    public StarshipRepository(ApplicationDbContext context) : base(context) { }
>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3
}
