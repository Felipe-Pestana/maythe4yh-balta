namespace MayTheFouthBackend.Domain.Entities.JoinEntity
{
    public sealed class MoviePlanet
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int PlanetId { get; set; }
        public Planet Planet { get; set; }
    }
}
