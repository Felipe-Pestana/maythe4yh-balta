using MayTheFouthBackend.Application.Features.Movie.GetAll;
using MayTheFouthBackend.Application.Features.Movie.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class MovieExtensions
    {
        public static void MapMovieEndpoint(this WebApplication app)
        {
            app.MapGet("/api/v1/movies", async ([FromServices] IMediator mediator, int currentPage = 1, int pageSize = 10) =>
            {

                var query = new MovieGetAllQuery
                {
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Movie");

            app.MapGet("/api/v1/movies/{id:int}", async (int id, [FromServices] IMediator mediator) =>
            {
                var query = new MovieGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result);

            }).WithTags("Movie");
        }
    }
}
