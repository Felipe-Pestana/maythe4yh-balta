namespace MayTheFouthBackend.Domain.Entities.JoinEntity
{
    public sealed class MoviePlanet
    {
        public int MoviesId { get; set; }
        public Movie Movie { get; set; }

        public int PlanetId { get; set; }
        public Planet Planet { get; set; }
    }
}
