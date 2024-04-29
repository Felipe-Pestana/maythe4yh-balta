namespace MayTheFouthBackend.Domain.Interfaces.IRepositories;

public interface IUnitOfWork
{
    public IPlanetRepository PlanetRepository { get;}

    public IStarshipRepository StarshipRepository { get;}

    public ICharacterRepository CharacterRepository { get; }
    public IVehicleRepository VehicleRepository { get; }
  
    Task Commit(CancellationToken cancellationToken);
}
