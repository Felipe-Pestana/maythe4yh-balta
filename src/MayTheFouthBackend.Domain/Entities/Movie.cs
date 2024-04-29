namespace MayTheFouthBackend.Domain.Entities
{
    public class Movie : Entity
    {

        private IReadOnlyCollection<Character> _characteres;
        private IReadOnlyCollection<Planet> _planets;
        private IReadOnlyCollection<Vehicle> _vehicles;
        private IReadOnlyCollection<Starship> _starships;


        public string Title { get; private set; }
        public int Episode { get; private set; }
        public string Opening_crawl { get; private set; } = string.Empty;
        public string Director { get; private set; } = string.Empty;
        public string Producer { get; private set; } = string.Empty;
        public DateTime Release_date { get; private set; }
        public DateTime Created { get; private set; } = DateTime.Now;
        public DateTime Edited { get; private set; }


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
        }
    }
}

