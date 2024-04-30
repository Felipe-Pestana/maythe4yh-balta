namespace MayTheFouthBackend.Domain.Entities.JoinEntity;

public sealed class MovieStarship
{
    public int MoviesId { get; set; }
    public Movie Movie { get; set; }

    public int StarshipId { get; set; }
    public Starship Starship { get; set; }
}
