using MayTheFouthBackend.Application.Features.Character.GetAll;
using MayTheFouthBackend.Application.Features.Character.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions;

public static class CharacterExtensions
{
    public static void MapCharacterEndpoint(this WebApplication app)
    {
        app.MapGet("api/v1/characters", async (int? pageSize, int? currentPage, [FromServices] IMediator mediator) =>
        {

            var query = new CharacterGetAllQuery
            {
                CurrentPage = currentPage ??0 ,
                PageSize = pageSize ?? 0,
            };

            var result = await mediator.Send(query);

            return result == null ? Results.NotFound(result) : Results.Ok(result);

        }).WithTags("Character");

        app.MapGet("api/v1/Character/{id:int}", async (int id, [FromServices] IMediator mediator) =>
        {
            var query = new CharacterGetByIdQuery { Id = id };
            var result = await mediator.Send(query);

            return result == null ? Results.NotFound() : Results.Ok(result);

        }).WithTags("Character");
    }
}
