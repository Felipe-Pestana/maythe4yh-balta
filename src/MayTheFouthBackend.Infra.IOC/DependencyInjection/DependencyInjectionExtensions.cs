using MayTheFouthBackend.Application.Features.Planet.GetAll;
using MayTheFouthBackend.Application.Features.Planet.GetById;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;
using MayTheFouthBackend.Infra.Data.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MayTheFouthBackend.Infra.IOC.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
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

        public static void AddPlanetService(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<PlanetGetAllQuery, ResponsePlanetGetAll>, PlanetGetAllQueryHandler>();
            services.AddScoped<IRequestHandler<PlanetGetByIdQuery, ResponsePlanetGetById>, PlanetGetByIdQueryHandler>();
        }
    }
}
