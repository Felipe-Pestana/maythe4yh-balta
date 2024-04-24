namespace MayTheFouthBackend.Presentation.Extensions;

public static class CharacterExtensions
{
    public static void MapCharacterEndpoint(this WebApplication app)
    {
        app.MapGet("/character", () => "Hello Personagem!").WithTags("character");
    }
}
