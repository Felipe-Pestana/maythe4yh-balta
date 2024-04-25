namespace MayTheFouthBackend.Domain.Interfaces.IRepositories;

public interface IUnitOfWork
{
    public IPlanetRepository PlanetRepository { get;}
    public IStarshipRepository StarshipRepository { get;}
    Task Commit(CancellationToken cancellationToken);
}
