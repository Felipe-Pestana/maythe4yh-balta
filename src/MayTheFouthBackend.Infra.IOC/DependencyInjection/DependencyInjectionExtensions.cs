using MayTheFouthBackend.Application.Features.Character.GetAll;
using MayTheFouthBackend.Application.Features.Character.GetById;
using MayTheFouthBackend.Application.Features.Movie.GetAll;
using MayTheFouthBackend.Application.Features.Movie.GetById;
using MayTheFouthBackend.Application.Features.Planet.GetAll;
using MayTheFouthBackend.Application.Features.Planet.GetById;
using MayTheFouthBackend.Application.Features.Starship.GetAll;
using MayTheFouthBackend.Application.Features.Starship.GetById;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using MayTheFouthBackend.Infra.Data.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace MayTheFouthBackend.Infra.IOC.DependencyInjection;

public static class DependencyInjectionExtensions
{
    public static void AddAllServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabaseService(configuration);
        services.AddRegisterService();
        services.AddCharacterService();
        services.AddPlanetService();
    }
    public static void AddRegisterService(this IServiceCollection services)
    {
        services.AddMediatR(confg => confg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPlanetRepository, PlanetRepository>();
    }

    public static void AddDatabaseService(this IServiceCollection services, IConfiguration configuration)
    {
        var connetionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connetionString));
    }
    public static void AddCharacterService(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<CharacterGetAllQuery, ResponseCharacterGetAll>, CharacterGetAllQueryHandler>();
        services.AddScoped<IRequestHandler<CharacterGetByIdQuery, ResponseCharacterGetById>, CharacterGetByIdQueryHandler>();
    }

    public static void AddPlanetService(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<PlanetGetAllQuery, ResponsePlanetGetAll>, PlanetGetAllQueryHandler>();
        services.AddScoped<IRequestHandler<PlanetGetByIdQuery, ResponsePlanetGetById>, PlanetGetByIdQueryHandler>();
    }

    public static void AddStarShipService(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<StarshipGetAllQuery, ResponseStarshipGetAll>, StarshipGetAllQueryHandler>();
        services.AddScoped<IRequestHandler<StarshipGetByIdQuery, ResponseStarshipGetById>, StarshipGetByIdQueryHandler>();

    }
    public static void AddMovieService(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<MovieGetByIdQuery, ResponseMovieGetById>, MovieGetByIdQueryHandler>();
        services.AddScoped<IRequestHandler<MovieGetAllQuery, ResponseMovieGetAll>, MovieGetAllQueryHandler>();
    }

    public static void AddVehicleService(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<VehicleGetByIdQuery, ResponseVehicleGetById>, VehicleGetByIdQueryHandler>();
        services.AddScoped<IRequestHandler<VehicleGetAllQuery, ResponseVehicleGetAll>, VehicleGetAllQueryHandler>();
    }    
    public static void AddChapterService(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<CharacterGetByIdQuery, ResponseCharacterGetById>, CharacterGetByIdQueryHandler>();
        services.AddScoped<IRequestHandler<CharacterGetAllQuery, ResponseCharacterGetAll>, CharacterGetAllQueryHandler>();
    }
}
