using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class StarshipRepository
    : BaseRepository<Starship>, IStarshipRepository
{
    private readonly ApplicationDbContext _context; 
    public StarshipRepository(ApplicationDbContext context)
        : base(context)
    {
        _context = context;
    }

    public  async Task<IEnumerable<Starship>> GetAllStarshipWhithInfosAsync()
    {
        return await _context
                        .Starships
                        .AsNoTracking()
                        .Include(x => x.Movies)
                        .ToListAsync(); 
    }

    public async Task<Starship> GetStarshipWithInfoAsync(int id)
    {
        return await _context
                        .Starships
                        .AsNoTracking()
                        .Include(x => x.Movies)
                        .FirstOrDefaultAsync(x=>x.Id ==id);
    }
}
