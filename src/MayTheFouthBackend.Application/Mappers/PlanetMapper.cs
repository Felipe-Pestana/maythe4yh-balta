using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Mappins
{
    public static class PlanetMapper
    {
        public static PlanetDto MapToPlanetDto(this Planet planet)
        {
            return new PlanetDto
            {
                Name = planet.Name,
                Climate = planet.Climate,
                Diameter = planet.Diameter,
                Gravity = planet.Gravity,
                OrbitalPeriod = planet.OrbitalPeriod,
                Population = planet.Population,
                RotationPeriod = planet.RotationPeriod,
                SurfaceWater = planet.SurfaceWater,
                Terrain = planet.Terrain,
                Movies = planet.Movies.Select(x => new MoveInfoDto { Id = x.Id, Title = x.Title })
            };
        }

        public static IEnumerable<PlanetDto> MapToIEnumerablePlanetDto(this IEnumerable<Planet> planets)
        {
            var planetsDtos = new List<PlanetDto>();
            foreach (var planet in planets)
            {
                planetsDtos.Add(MapToPlanetDto(planet));
            }
            return planetsDtos;
        }
    }
}
