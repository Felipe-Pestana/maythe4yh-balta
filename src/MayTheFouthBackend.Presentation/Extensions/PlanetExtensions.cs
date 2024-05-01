using MayTheFouthBackend.Application.Features.Planet.GetAll;
using MayTheFouthBackend.Application.Features.Planet.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class PlanetExtensions
    {
        public static void MapPlanetEndpoint(this WebApplication app)
        {
            app.MapGet("/api/v1/planets", async ([FromServices] IMediator mediator, int currentPage = 1, int pageSize = 10) =>
            {

                var query = new PlanetGetAllQuery
                {

                    CurrentPage = currentPage,
                    PageSize = pageSize,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Planet");

            app.MapGet("/api/v1/planets/{id:int}", async ([FromServices] IMediator mediator, int id) =>
            {
                var query = new PlanetGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("Planet");
        }
    }
}
