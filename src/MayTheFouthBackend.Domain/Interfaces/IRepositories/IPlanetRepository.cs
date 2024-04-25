using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories; 

public interface IPlanetRepository 
    : IBaseRepository<Planet>
{
    Task<Planet> GetPlanetWithInfo(int id); 
}
