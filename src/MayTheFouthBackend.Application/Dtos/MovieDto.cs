namespace MayTheFouthBackend.Application.Dtos;

public sealed class MovieDto
{
    public string Title { get; set; } = string.Empty;
    public int Episode { get; set; }
    public string OpeningCrawl { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public IEnumerable<ListInfoDto> Starships { get; set; } = Enumerable.Empty<ListInfoDto>();
    public IEnumerable<ListInfoDto> Planets { get; set; } = Enumerable.Empty<ListInfoDto>();
    public IEnumerable<ListInfoDto> Vehicles { get; set; } = Enumerable.Empty<ListInfoDto>();
    public IEnumerable<ListInfoDto> Characters { get; set; } = Enumerable.Empty<ListInfoDto>();
}
