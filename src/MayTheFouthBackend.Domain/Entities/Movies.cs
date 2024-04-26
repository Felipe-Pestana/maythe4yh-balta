using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Domain.Entities
{
    public class Movies : Entity
    {
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

        public Movies(
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

