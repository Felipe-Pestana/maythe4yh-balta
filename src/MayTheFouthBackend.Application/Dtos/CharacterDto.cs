using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Dtos;

public class CharacterDto
{

    public string Name { get; set; } = string.Empty;
    public float Height { get;  set; }
    public float Weight { get;  set; }
    public string HairColor { get;  set; } = string.Empty;
    public string SkinColor { get; set; } = string.Empty;
    public string EyeColor { get; set; } = string.Empty;
    public int BirthYear { get;  set; }
    public string Gender { get; set; } = string.Empty;
    public int PlanetId { get;  set; }
    public Planet Homeworld { get;  set; }

    public IEnumerable<ListInfoDto> Movies { get; set; } = Enumerable.Empty<ListInfoDto>();
}
