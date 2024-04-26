using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class PlanetRepository : BaseRepository<Planet>, IPlanetRepository
{
    public PlanetRepository(ApplicationDbContext context) 
        : base(context)
    {
    }
}
