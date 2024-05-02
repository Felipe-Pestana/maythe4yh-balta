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
                Id = starship.Id.ToString(),
                Name = starship.Name,
                Model = starship.Model,
                Manufacturer = starship.Manufacturer,
                CostInCredits = (int)starship.CostInCredits,
                Length = (int)starship.Length,
                Maxspeed = starship.Maxspeed,
                Crew = starship.Crew,
                Passengers = starship.Passengers,
                Cargocapacity = (int)starship.Cargocapacity,
                HyperDriveRating = starship.HyperDriveRating.ToString(),
                MGLT = starship.MGLT.ToString(),
                Consumables = starship.Consumables,
                Class = starship.Class,
                Movies = starship.Movies?.Select(x => new ListInfoDto { Id = x.Id.ToString(), Title = x.Title })
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
