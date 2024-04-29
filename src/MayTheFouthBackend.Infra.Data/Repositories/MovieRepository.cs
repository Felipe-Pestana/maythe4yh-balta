using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMoviesRepository
{
    private ApplicationDbContext _context;
    public MovieRepository(ApplicationDbContext context)
        : base(context)
    {
        _context = context;
    }

    public Task<Movie> GetMoviesByIdWithInfoAsync(int id)
    {
        throw new NotImplementedException();
    }
}
