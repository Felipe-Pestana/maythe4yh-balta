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
