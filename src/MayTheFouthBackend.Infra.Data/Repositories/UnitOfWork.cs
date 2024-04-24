using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IPlanetRepository _planetRepository;
    private ICharacterRepository _characterRepository;
    private ApplicationContext _context;

    public UnitOfWork(ApplicationContext context)
    {
        _context = context;
    }

    public IPlanetRepository PlanetRepository => _planetRepository?? new PlanetRepository(_context);

    public ICharacterRepository CharacterRepository => _characterRepository?? new CharacterRepository(_context);

    public async Task Commit(CancellationToken cancellationToken)
    {
       await _context.SaveChangesAsync(); 
    }
}
