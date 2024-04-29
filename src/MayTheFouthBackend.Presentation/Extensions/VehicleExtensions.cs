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
            app.MapGet("/api/v1/vehicle", async ([FromServices] IMediator mediator, int currentPage = 1, int pageSize = 10) =>
            {

                var query = new VehicleGetAllQuery
                {

                    CurrentPage = currentPage,
                    PageSize = pageSize,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Vehicle");

            app.MapGet("/api/v1/vehicle/{id:int}", async ([FromServices] IMediator mediator, int id) =>
            {
                var query = new VehicleGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("Vehicle");
        }
    }
}
