using MayTheFouthBackend.Domain.Entities;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Infra.Data.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }
        public async Task<Vehicle> GetVehicleWithInfoById(int id)
        {
            return await _context
                            .Vehicles
                            .AsNoTracking()
                            .Include(x => x.Movies)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
