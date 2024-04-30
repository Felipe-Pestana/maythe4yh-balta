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
        public string OpeningCrawl { get; private set; } = string.Empty;
        public string Director { get; private set; } = string.Empty;
        public string Producer { get; private set; } = string.Empty;
        public DateTime ReleaseDate { get; private set; }
        public DateTime Created { get; private set; } = DateTime.Now;
        public DateTime Edited { get; private set; }
        public ICollection<Starship> Starships { get =>_starships;}
        public ICollection<Planet> Planets { get =>_planets;}
        public ICollection<Vehicle> Vehicles { get =>_vehicles;}
        public ICollection<Character> Characters { get =>_characteres;}



        public Movie(
                string title,
                int episode,
                string openingCrawl,
                string director,
                string producer,
                DateTime releasseDate)
        {
            Title = title;
            Episode = episode;
            OpeningCrawl = openingCrawl;
            Director = director;
            Producer = producer;
            ReleaseDate = releasseDate;
            _characteres = new(); 
            _planets = new();
            _starships = new();
            _vehicles = new();
        }
        private Movie()
        {
            
        }
    }
}

