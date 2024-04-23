using MayTheFouthBackend.Application.Features.Planet.GetAll;
using MayTheFouthBackend.Application.Features.Planet.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static  class PlanetExtensions
    {
        public static void MapPlanetEndpoint(this WebApplication app)
        {
            app.MapGet("/Planet", async ([FromQuery] PlanetGetAllQuery query, [FromServices] IMediator  mediator) =>
            {
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("planet");

            app.MapGet("/Planet/{id:int}", async (int id , [FromServices] IMediator mediator) =>
            {
                var query = new PlanetGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result); 

            }).WithTags("planet");
        }
    }
}
