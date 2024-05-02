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
                Id = planet.Id.ToString(),
                Name = planet.Name,
                Climate = planet.Climate,
                Diameter = planet.Diameter,
                Gravity = planet.Gravity,
                OrbitalPeriod = planet.OrbitalPeriod,
                Population = planet.Population,
                RotationPeriod = planet.RotationPeriod,
                SurfaceWater = planet.SurfaceWater,
                Terrain = planet.Terrain,
                Characters = planet.Characters?.Select(c=> new ListInfoDto { Id = c.Id.ToString(), Title = c.Name}),
                Movies = planet.Movies?.Select(x => new ListInfoDto { Id = x.Id.ToString(), Title = x.Title })
              
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
