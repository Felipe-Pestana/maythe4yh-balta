namespace MayTheFouthBackend.Domain.Entities;

public class Planet : Entity
{
    private List<Character> _characteres = new();
    private List<Movie> _movies = new();
    public Planet(string name,
                float rotationPeriod,
                int orbitalPeriod,
                int diameter,
                string climate,
                string gravity,
                string terrain,
                float surfaceWater,
                int population)
    {
        Name = name;
        RotationPeriod = rotationPeriod;
        OrbitalPeriod = orbitalPeriod;
        Diameter = diameter;
        Climate = climate;
        Gravity = gravity;
        Terrain = terrain;
        SurfaceWater = surfaceWater;
        Population = population;

    }
    private Planet()
    {
        
    }

    public string Name { get; private set; }
    public float RotationPeriod { get; private set; }
    public int OrbitalPeriod { get; private set; }
    public int Diameter { get; private set; }
    public string Climate { get; private set; }
    public string Gravity { get; private set; }
    public string Terrain { get; private set; }
    public float SurfaceWater { get; private set; }
    public int Population { get; private set; }

    public IReadOnlyCollection<Character> Characters { get => _characteres; }
    public IReadOnlyCollection<Movie> Movies { get => _movies; }

    public void AddCharacter(Character character) => _characteres.Add(character);
    public void AddMoveis(Movie move) => _movies.Add(move);
}
