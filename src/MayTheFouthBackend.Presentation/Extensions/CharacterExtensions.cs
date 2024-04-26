using MayTheFouthBackend.Application.Features.Character.GetAll;
using MayTheFouthBackend.Application.Features.Character.GetById;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions;

public static class CharacterExtensions
{
    public static void MapCharacterEndpoint(this WebApplication app)
    {
        app.MapGet("/characters", async (int pageSize, int currentPage, [FromServices] IMediator mediator) =>
        {

            var query = new CharacterGetAllQuery
            {

                CurrentPage = currentPage,
                PageSize = pageSize,
            };

            var result = await mediator.Send(query);

            return result == null ? Results.NotFound(result) : Results.Ok(result);

        }).WithTags("character");

        app.MapGet("/Character/{id:int}", async (int id, [FromServices] IMediator mediator) =>
        {
            var query = new CharacterGetByIdQuery { Id = id };
            var result = await mediator.Send(query);

            return result == null ? Results.NotFound() : Results.Ok(result);

        }).WithTags("character");
    }
}
