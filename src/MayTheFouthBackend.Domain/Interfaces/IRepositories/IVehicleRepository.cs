﻿using MayTheFouthBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Domain.Interfaces.IRepositories
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Task<Vehicle> GetVehicleWithInfoById(int id);
        Task<IEnumerable<Vehicle>> GetAllStarshipWhithInfosAsync();
    }
}
