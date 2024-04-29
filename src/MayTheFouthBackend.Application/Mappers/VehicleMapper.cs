using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Mappins
{
    public static class VehicleMapper
    {
        public static VehicleDto MapToVehicleDto(this Vehicle vehicle)
        {
            return new VehicleDto
            {
                Name = vehicle.Name,
                Model = vehicle.Model,
                Manufacturer = vehicle.Manufacturer,
                CostInCredits = vehicle.CostInCredits,
                Length = vehicle.Length,
                Maxspeed = vehicle.Maxspeed,
                Crew = vehicle.Crew,
                Passengers = vehicle.Passengers,
                Cargocapacity = vehicle.Cargocapacity,
                Consumables = vehicle.Consumables,
                Class = vehicle.Class,
                Movies = vehicle.Movies.Select(x => new ListInfoDto { Id = x.Id, Title = x.Title })
            };
        }

        public static IEnumerable<VehicleDto> MapToIEnumerableVehicleDto(this IEnumerable<Vehicle> vehicles)
        {
            var vehiclesDtos = new List<VehicleDto>();
            foreach (var vehicle in vehicles)
            {
                vehiclesDtos.Add(MapToVehicleDto(vehicle));
            }
            return vehiclesDtos;
        }
    }
}
