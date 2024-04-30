using MayTheFouthBackend.Application.Features.Starship.GetAll;
using MayTheFouthBackend.Application.Features.Starship.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class StarshipExtensions
    {
        public static void MapStarshipEndpoint(this WebApplication app)
        {
            app.MapGet("/api/v1/starship", async ([FromServices] IMediator mediator, int currentPage = 1, int pageSize = 10) =>
            {

                var query = new StarshipGetAllQuery
                {

                    CurrentPage = currentPage,
                    PageSize = pageSize,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Starship");

            app.MapGet("/api/v1/starship/{id:int}", async ([FromServices] IMediator mediator, int id) =>
            {
                var query = new StarshipGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("Starship");
        }
    }
}
