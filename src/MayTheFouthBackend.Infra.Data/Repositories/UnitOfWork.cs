using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IPlanetRepository _planetRepository;
<<<<<<< HEAD

    private IStarshipRepository _starshipRepository;
    private ApplicationContext _context;

    private ICharacterRepository _characterRepository;
    private ApplicationDbContext _context;


=======
    private ApplicationDbContext _context;

>>>>>>> 3ad735c7c1d5dbd080b1f791f799d197f3054331
    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public IPlanetRepository PlanetRepository => _planetRepository?? new PlanetRepository(_context);
    public IStarshipRepository StarshipRepository => _starshipRepository?? new StarshipRepository(_context);

    public ICharacterRepository CharacterRepository => _characterRepository?? new CharacterRepository(_context);

    public async Task Commit(CancellationToken cancellationToken)
    {
       await _context.SaveChangesAsync(); 
    }
}
