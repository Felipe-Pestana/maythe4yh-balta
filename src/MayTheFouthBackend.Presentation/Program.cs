using MayTheFouthBackend.Infra.Data.Contexts;
using MayTheFouthBackend.Presentation.Extensions;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using MayTheFouthBackend.Infra.IOC.DependencyInjection;

=======
using MayTheFouthBackend.Infra.IOC.DependencyInjection; 
>>>>>>> 3ad735c7c1d5dbd080b1f791f799d197f3054331

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
<<<<<<< HEAD
builder.Services.AddSwaggerGen();
builder.Services.AddAllServices(builder.Configuration);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
=======
builder.AddSwaggerGenService();

builder.Services.AddRegisterService(); 
builder.Services.AddDatabaseService(builder.Configuration);
builder.Services.AddPlanetService(); 


>>>>>>> 3ad735c7c1d5dbd080b1f791f799d197f3054331
var app = builder.Build();

app.useSwaggerApp(); 

app.UseHttpsRedirection();


app.MapPlanetEndpoint();
app.MapStarshipEndpoint();

app.MapPlanetEndpoint(); 
app.MapCharacterEndpoint();


app.Run();

