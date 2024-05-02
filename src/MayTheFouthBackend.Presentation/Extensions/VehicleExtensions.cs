using MayTheFouthBackend.Application.Features.Starship.GetAll;
using MayTheFouthBackend.Application.Features.Starship.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class VehicleExtensions
    {
        public static void MapVehicleEndpoint(this WebApplication app)
        {
            app.MapGet("/api/v1/vehicles", async ([FromServices] IMediator mediator, int pageNumber = 1, int pageSize = 10) =>
            {

                var query = new VehicleGetAllQuery
                {

                    CurrentPage = pageNumber,
                    PageSize = pageSize,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Vehicle");

            app.MapGet("/api/v1/vehicles/{id:int}", async ([FromServices] IMediator mediator, int id) =>
            {
                var query = new VehicleGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("Vehicle");
        }
    }
}
