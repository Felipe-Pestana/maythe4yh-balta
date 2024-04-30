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
                Name = starship.Name,
                Model = starship.Model,
                Manufacturer = starship.Manufacturer,
                CostInCredits = starship.CostInCredits,
                Length = starship.Length,
                Maxspeed = starship.Maxspeed,
                Crew = starship.Crew,
                Passengers = starship.Passengers,
                Cargocapacity = starship.Cargocapacity,
                HyperDriveRating = starship.HyperDriveRating,
                MGLT = starship.MGLT,
                Consumables = starship.Consumables,
                Class = starship.Class,
                Movies = starship.Movies?.Select(x => new ListInfoDto { Id = x.Id, Title = x.Title })
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
