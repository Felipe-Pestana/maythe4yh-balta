using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    private ApplicationDbContext _context;
    public MovieRepository(ApplicationDbContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<Movie> GetMoviesByIdWithInfoAsync(int id)
    {
        return await _context.Movies
                        .AsNoTracking()
                        .Include(x => x.Planets)
                        .Include(x => x.Starships)
                        .Include(x => x.Characters)
                        .Include(x => x.Vehicles)
                        .FirstOrDefaultAsync(x => x.Id == id); 
    }
}
