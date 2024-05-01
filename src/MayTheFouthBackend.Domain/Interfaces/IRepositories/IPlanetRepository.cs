using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories; 

public interface IPlanetRepository 
    : IBaseRepository<Planet>
{
    Task<IEnumerable<Planet>> GetAllPlanetWhithInfosAsync();
    Task<Planet> GetPlanetWithInfoAsync(int id); 
}
