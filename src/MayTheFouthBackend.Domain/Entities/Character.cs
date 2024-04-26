namespace MayTheFouthBackend.Domain.Entities;

public class Character : Entity
{
    private List<int> _movies;
    private List<Planet> _homeworld;
    public Character(string name,
                string height,
                string weight,
                string hairColor,
                string skinColor,
                string eyeColor,
                string birthYear,
                string gender,
                string homeworld,
                string movies
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
        Movies = movies;

        _homeworld = new List<Planet>();
        _movies = new List<int>();
    }

    public string Name { get; private set; }
    public string Height { get; private set; }
    public string Weight { get; private set; }
    public string HairColor { get; private set; }
    public string SkinColor { get; private set; }
    public string EyeColor { get; private set; }
    public string BirthYear { get; private set; }
    public string Gender { get; private set; }
    public string Homeworld { get; private set; }
    public string Movies { get; private set;}

    public void AddHomeworld(Planet homeworld) => _homeworld.Add(homeworld);
    public void AddMovies(int move) => _movies.Add(move);
}
