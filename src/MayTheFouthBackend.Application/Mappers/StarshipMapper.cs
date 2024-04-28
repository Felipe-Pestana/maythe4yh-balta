using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Mappers
{
    public static class StarshipMapper
    {
        public static StarshipDto MapToStarshipDto(this Starship starship)
        {
            return new StarshipDto
            {

            };
        }

        public static IEnumerable<StarshipDto> MapToIEnumerableStarhipDto(this IEnumerable<Starship> starships)
        {
            var starhipDto = new List<StarshipDto>();

            foreach (var starship in starships)
            {
                starhipDto.Add(MapToStarshipDto(starship));
            }
            return starhipDto;
        }
    }
}
