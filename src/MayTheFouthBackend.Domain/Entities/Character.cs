namespace MayTheFouthBackend.Domain.Entities;

public class Character : Entity
{
    private List<Movie> _movies = new();
    public Character(string name,
                float height,
                float weight,
                string hairColor,
                string skinColor,
                string eyeColor,
                int birthYear,
                string gender,
                int planetId
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
        PlanetId = planetId;
    }

    private Character()
    {
        
    }

    public string Name { get; private set; }
    public float Height { get; private set; }
    public float Weight { get; private set; }
    public string HairColor { get; private set; }
    public string SkinColor { get; private set; }
    public string EyeColor { get; private set; }
    public int BirthYear { get; private set; }
    public string Gender { get; private set; }
    public int PlanetId { get; private set; }
    public Planet Homeworld { get; private set; }

    public ICollection<Movie> Movies { get => _movies;  }

    public void AddMovies(Movie move) => _movies.Add(move);
}
