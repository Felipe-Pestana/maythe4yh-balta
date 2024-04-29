using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories
{
    public interface IMoviesRepository 
        : IBaseRepository<Movie>
    {
        Task<Movie> GetMoviesByIdWithInfoAsync(int id);
    }
}
