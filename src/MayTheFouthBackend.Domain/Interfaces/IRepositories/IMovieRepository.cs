using MayTheFouthBackend.Domain.Entities;
using System.Reflection;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories
{
    public interface IMovieRepository 
        : IBaseRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetAllMoviesWithInfoAsync();
        Task<Movie> GetMoviesByIdWithInfoAsync(int id);
    }
}
