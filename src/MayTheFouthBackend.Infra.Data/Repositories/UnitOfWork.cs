using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IPlanetRepository _planetRepository;
<<<<<<< HEAD

    private IStarshipRepository _starshipRepository;

    private ICharacterRepository _characterRepository;

    private ApplicationDbContext _context;

=======
    private IStarshipRepository _starshipRepository;
    private ICharacterRepository _characterRepository;




    private readonly ApplicationDbContext _context;

>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3
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
