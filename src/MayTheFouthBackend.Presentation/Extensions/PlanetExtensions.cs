namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class PlanetExtensions
    {
        public static void MapPlanetEndpoint(this WebApplication app)
        {
            app.MapGet("/teste", () => "ola Paneta!").WithTags("planet"); 
        }
    }
}
