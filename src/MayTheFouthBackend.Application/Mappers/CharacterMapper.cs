using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Mappers;

public static class CharacterMapper
{
    public static CharacterDto MapToCharacterDto(this Character character)
    {
        return new CharacterDto
        {
            Name = character.Name,
            BirthYear = character.BirthYear,
            EyeColor = character.EyeColor,
            Gender = character.Gender,
            HairColor = character.HairColor,
            Height = character.Height,
            Homeworld = character.Homeworld,
            PlanetId = character.PlanetId,
            SkinColor = character.SkinColor,
            Weight = character.Weight,
            Movies = character.Movies?.Select(x => new ListInfoDto { Id = x.Id, Title = x.Title})
        };
    }

    public static IEnumerable<CharacterDto> MapToIEnumerableCharacterDto(this IEnumerable<Character> character)
    {
        var characterDtos = new List<CharacterDto>();
        foreach (var c in character)
        {
            characterDtos.Add(MapToCharacterDto(c));
        }
        return characterDtos;
    }
}
