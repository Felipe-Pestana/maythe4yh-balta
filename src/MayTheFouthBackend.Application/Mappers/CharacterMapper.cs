using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Mappers;

public static class CharacterMapper
{
    public static CharacterDto MapToCharacterDto(this Character character)
    {
        return new CharacterDto
        {
            
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
