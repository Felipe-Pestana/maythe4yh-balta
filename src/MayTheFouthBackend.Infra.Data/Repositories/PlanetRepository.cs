using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class PlanetRepository : BaseRepository<Planet>, IPlanetRepository
{
    private readonly ApplicationDbContext _context;
    public PlanetRepository(ApplicationDbContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Planet>> GetAllPlanetWhithInfosAsync()
    {
        return await _context
              .Planets
              .AsNoTracking()
              .Include(x => x.Characters)
              .Include(x => x.Movies)
              .ToListAsync();
    }

    public async Task<Planet> GetPlanetWithInfoAsync(int id)
    {

        return await _context
                        .Planets
                        .AsNoTracking()
                        .Include(x => x.Characters)
                        .Include(x => x.Movies)
                        .FirstOrDefaultAsync(x => x.Id == id);
    }
}
