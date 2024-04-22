namespace MayTheFouthBackend.Domain.Interfaces.IRepositories;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}
