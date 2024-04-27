using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Infra.Data.Repositories
{
    public class StarshipRepository :BaseRepository<Starship>, IStarshipRepository
    {
        public StarshipRepository(ApplicationDbContext context) : base(context) { }
    }
}
