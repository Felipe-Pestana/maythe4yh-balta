using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Domain.Entities
{
    public class Vehicle : Entity
    {
        private List<Movie> _movies;

        public Vehicle(string name,
            string model,
            string manufacturer,
            float costInCredits,
            float length,
            int maxspeed,
            int crew,
            int passagers,
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
            Passagers = passagers;
            Cargocapacity = cargocapacity;            
            Consumables = consumables;
            Class = @class;

            _movies = new List<Movie>();
        }

        public string Name { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public float CostInCredits { get; private set; }
        public float Length { get; private set; }
        public int Maxspeed { get; private set; }
        public int Crew { get; private set; }
        public int Passagers { get; private set; }
        public float Cargocapacity { get; private set; }        
        public string Consumables { get; private set; }
        public string Class { get; private set; }

        public IReadOnlyCollection<Movie> Movies { get => _movies; }

        public void AddMovies(Movie movie) => _movies.Add(movie);
    }
}
