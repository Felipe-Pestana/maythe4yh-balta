namespace MayTheFouthBackend.Domain.Entities;

public class Character : Entity
{
    private List<Movie> _movies;
    public Character(string name,
                string height,
                string weight,
                string hairColor,
                string skinColor,
                string eyeColor,
                string birthYear,
                string gender,
                Planet homeworld
              )
    {
        Name = name;
        Height = height;
        Weight = weight;
        HairColor = hairColor;
        SkinColor = skinColor;
        EyeColor = eyeColor;
        BirthYear = birthYear;
        Gender = gender;
        Homeworld = homeworld;

        _movies = new List<Movie>();
    }

    public string Name { get; private set; }
    public string Height { get; private set; }
    public string Weight { get; private set; }
    public string HairColor { get; private set; }
    public string SkinColor { get; private set; }
    public string EyeColor { get; private set; }
    public string BirthYear { get; private set; }
    public string Gender { get; private set; }
    public Planet Homeworld { get; private set; }
    public int PlanetId { get; private set; }
    public IReadOnlyCollection<Movie> Movies { get => _movies;  }

    public void AddMovies(Movie move) => _movies.Add(move);
}
