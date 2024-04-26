namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class StarshipExtensions
    {
        public static void MapStarshipEndpoint(this WebApplication app)
        {
            app.MapGet("/teste", () => "ola navinha").WithTags("starship");
        }
    }
}
