using MayTheFouthBackend.Application.Features.Character.GetAll;
using MayTheFouthBackend.Application.Features.Character.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions;

public static class CharacterExtensions
{
    public static void MapCharacterEndpoint(this WebApplication app)
    {
        app.MapGet("/api/v1/characters", async ([FromServices] IMediator mediator, int currentPage = 1, int pageSize = 10) =>
        {

            var query = new CharacterGetAllQuery
            {
                CurrentPage = currentPage,
                PageSize = pageSize,
            };

            var result = await mediator.Send(query);

            return result == null ? Results.NotFound(result) : Results.Ok(result);

        }).WithTags("Character");

        app.MapGet("/api/v1/Characters/{id:int}", async ([FromServices] IMediator mediator, int id) =>
        {
            var query = new CharacterGetByIdQuery { Id = id };
            var result = await mediator.Send(query);

            return result == null ? Results.NotFound() : Results.Ok(result);

        }).WithTags("Character");
    }
}
