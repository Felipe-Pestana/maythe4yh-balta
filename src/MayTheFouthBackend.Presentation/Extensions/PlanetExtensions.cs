﻿using MayTheFouthBackend.Application.Features.Planet.GetAll;
using MayTheFouthBackend.Application.Features.Planet.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFouthBackend.Presentation.Extensions
{
    public static class PlanetExtensions
    {
        public static void MapPlanetEndpoint(this WebApplication app)
        {
            app.MapGet("/api/v1/planets", async (int? pageSize, int? currentPage, [FromServices] IMediator mediator) =>
            {

                var query = new PlanetGetAllQuery
                {

                    CurrentPage = currentPage ?? 0,
                    PageSize = pageSize ?? 0,
                };

                var result = await mediator.Send(query);

                return result == null ? Results.NotFound(result) : Results.Ok(result);

            }).WithTags("Planet");

            app.MapGet("/api/v1/Planet/{id:int}", async (int id , [FromServices] IMediator mediator) =>
            {
                var query = new PlanetGetByIdQuery { Id = id };
                var result = await mediator.Send(query);

                return result == null ? Results.NotFound() : Results.Ok(result); 

            }).WithTags("Planet");
        }
    }
}
