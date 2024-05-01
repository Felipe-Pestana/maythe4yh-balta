using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories;

public interface ICharacterRepository : IBaseRepository<Character> 
{
    Task<IEnumerable<Character>> GetAllCharactWhithInfosAsync();
    Task<Character> GetCharacterByIdWithInfoAsync(int id);
}
