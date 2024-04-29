using MayTheFouthBackend.Infra.Data.Contexts;
using MayTheFouthBackend.Infra.IOC.DependencyInjection;
using MayTheFouthBackend.Presentation.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddAllServices(builder.Configuration);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddRegisterService(); 
builder.Services.AddDatabaseService(builder.Configuration);
builder.Services.AddPlanetService();
builder.Services.AddStarShipService();
builder.Services.AddCharacterService();
builder.Services.AddVehicleService();

var app = builder.Build();

app.useSwaggerApp();

app.UseHttpsRedirection();

app.MapPlanetEndpoint();
app.MapStarshipEndpoint();
app.MapCharacterEndpoint();
app.MapVehicleEndpoint();

app.Run();

