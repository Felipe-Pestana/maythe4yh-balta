<<<<<<< HEAD
using MayTheFouthBackend.Infra.Data.Contexts;
using MayTheFouthBackend.Infra.IOC.DependencyInjection;
using MayTheFouthBackend.Presentation.Extensions;
using Microsoft.EntityFrameworkCore;
=======
using MayTheFouthBackend.Infra.IOC.DependencyInjection;
using MayTheFouthBackend.Presentation.Extensions;

>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
<<<<<<< HEAD
builder.Services.AddSwaggerGen();
builder.Services.AddAllServices(builder.Configuration);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.AddSwaggerGenService();



=======
builder.AddSwaggerGenService();

builder.Services.AddRegisterService();
builder.Services.AddDatabaseService(builder.Configuration);
builder.Services.AddPlanetService();

>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3
var app = builder.Build();

app.useSwaggerApp();

app.UseHttpsRedirection();


app.MapPlanetEndpoint();
app.MapStarshipEndpoint();
app.MapCharacterEndpoint();


app.Run();

