using MayTheFouthBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories
{
    public interface IStarshipRepository : IBaseRepository<Starship>
    {
        Task<IEnumerable<Starship>> GetAllStarshipWhithInfosAsync();
        Task<Starship> GetStarshipWithInfoAsync(int id); 
    }
}
