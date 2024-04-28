namespace MayTheFouthBackend.Domain.Entities
{
<<<<<<< HEAD
    public string Title { get; set; }
    public int Episode { get; set; }
    public string Opening_crawl { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public DateTime Release_date { get; set; }
    public DateTime Created { get; set; }
    = DateTime.Now;
    public DateTime Edited { get; set; }

    private List<int> _characteres;
    private List<int> _planets;
    private List<int> _vehicles;
    private List<int> _starships;

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
=======
    public class Movie : Entity
    {

        private IReadOnlyCollection<Character> _characteres;
        private IReadOnlyCollection<Planet> _planets;
        private IReadOnlyCollection<int> _vehicles;
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
>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3
    }
}

