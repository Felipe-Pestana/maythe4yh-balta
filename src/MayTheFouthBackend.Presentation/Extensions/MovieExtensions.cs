using MayTheFouthBackend.Application.Features.Movie.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class MovieExtensions
    {
        public static void MapMovieEndpoint(this WebApplication app)
        {
            app.MapGet("/api/v1/moveis", async (int? pageSize, int? currentPage, [FromServices] IMediator mediator) =>
            {

                //var query = new Move
                //{

                //    CurrentPage = currentPage ?? 0,
                //    PageSize = pageSize ?? 0,
                //};

                //var result = await mediator.Send(query);

                //return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Movie");

            app.MapGet("/api/v1/moveis/{id:int}", async (int id, [FromServices] IMediator mediator) =>
            {
                var query = new MovieGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("Movie");
        }
    }
}
