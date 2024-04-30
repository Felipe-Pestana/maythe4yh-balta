using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories
{
    public interface IMovieRepository 
        : IBaseRepository<Movie>
    {
        Task<Movie> GetMoviesByIdWithInfoAsync(int id);
    }
}
