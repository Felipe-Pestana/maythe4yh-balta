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
            app.MapGet("/api/v1/vehicles", async (int pageSize, int currentPage, [FromServices] IMediator mediator) =>
            {

                var query = new VehicleGetAllQuery
                {

                    CurrentPage = currentPage,
                    PageSize = pageSize,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("vehicle");

            app.MapGet("/api/v1/vehicle/{id:int}", async (int id, [FromServices] IMediator mediator) =>
            {
                var query = new VehicleGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("vehicle");
        }
    }
}
