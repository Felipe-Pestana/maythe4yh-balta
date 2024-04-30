namespace MayTheFouthBackend.Domain.Entities.JoinEntity
{
    public sealed class MovieCharacter
    {
        public int MoviesId { get; set; }
        public Movie Movie { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
