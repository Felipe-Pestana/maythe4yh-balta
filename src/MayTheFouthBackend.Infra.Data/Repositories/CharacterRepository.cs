using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
{
    public CharacterRepository(ApplicationDbContext context)
       : base(context)
    {
    }
}
