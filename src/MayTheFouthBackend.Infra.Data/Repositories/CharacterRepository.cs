using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
{
    private readonly ApplicationDbContext _context;
    public CharacterRepository(ApplicationDbContext context)
       : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Character>> GetAllCharactWhithInfosAsync()
    {
        return await _context.Characters
                        .AsNoTracking()
                        .Include(x => x.Homeworld)
                        .Include(x => x.Movies)
                        .ToListAsync(); 
    }

    public async Task<Character> GetCharacterByIdWithInfoAsync(int id)
    {
        return await _context.Characters
                .AsNoTracking()
                .Include(x => x.Homeworld)
                .Include(x => x.Movies)
                .FirstOrDefaultAsync(x=>x.Id ==id);
    }
}
