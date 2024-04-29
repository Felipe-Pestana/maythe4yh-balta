namespace MayTheFouthBackend.Domain.Entities
{
    public class Movie : Entity
    {

        private List<Character> _characteres;
        private List<Planet> _planets;
        private List<Vehicle> _vehicles;
        private List<Starship> _starships;

        public string Title { get; private set; }
        public int Episode { get; private set; }
        public string Opening_crawl { get; private set; } = string.Empty;
        public string Director { get; private set; } = string.Empty;
        public string Producer { get; private set; } = string.Empty;
        public DateTime Release_date { get; private set; }
        public DateTime Created { get; private set; } = DateTime.Now;
        public DateTime Edited { get; private set; }
        public IReadOnlyCollection<Starship> Starships { get =>_starships;}
        public IReadOnlyCollection<Planet> Planets { get =>_planets;}
        public IReadOnlyCollection<Vehicle> Vehicles { get =>_vehicles;}
        public IReadOnlyCollection<Character> Characters { get =>_characteres;}



        public Movie(
                string title,
                int episode,
                string opening_crawl,
                string director,
                string producer,
                DateTime releasse_date)
        {
            Title = title;
            Episode = episode;
            Opening_crawl = opening_crawl;
            Director = director;
            Producer = producer;
            Release_date = releasse_date;
            _characteres = new(); 
            _planets = new();
            _starships = new();
            _vehicles = new();
        }
    }
}

