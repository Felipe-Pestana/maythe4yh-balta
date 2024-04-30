namespace MayTheFouthBackend.Domain.Entities
{
    public class Vehicle : Entity
    {
        private List<Movie> _movies = new();

        public Vehicle(string name,
            string model,
            string manufacturer,
            float costInCredits,
            float length,
            int maxspeed,
            int crew,
            int passengers,
            float cargocapacity,
            string consumables,
            string @class)
        {
            Name = name;
            Model = model;
            Manufacturer = manufacturer;
            CostInCredits = costInCredits;
            Length = length;
            Maxspeed = maxspeed;
            Crew = crew;
            Passengers = passengers;
            Cargocapacity = cargocapacity;
            Consumables = consumables;
            Class = @class;
        }
        private Vehicle()
        {

        }

        public string Name { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public float CostInCredits { get; private set; }
        public float Length { get; private set; }
        public int Maxspeed { get; private set; }
        public int Crew { get; private set; }
        public int Passengers { get; private set; }
        public float Cargocapacity { get; private set; }
        public string Consumables { get; private set; }
        public string Class { get; private set; }

        public ICollection<Movie> Movies { get => _movies; }

        public void AddMovies(Movie movie) => _movies.Add(movie);
    }
}
