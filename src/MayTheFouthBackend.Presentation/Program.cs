
using MayTheFouthBackend.Infra.IOC.DependencyInjection;
using MayTheFouthBackend.Presentation.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.AddSwaggerGenService();

builder.Services.AddRegisterService();
builder.Services.AddDatabaseService(builder.Configuration);
builder.Services.AddPlanetService();
builder.Services.AddMovieService();
builder.Services.AddVehicleService();
builder.Services.AddChapterService(); 

var app = builder.Build();

app.useSwaggerApp();

app.UseHttpsRedirection();

app.MapPlanetEndpoint();
app.MapStarshipEndpoint();
app.MapCharacterEndpoint();
app.MapMovieEndpoint();
app.MapVehicleEndpoint(); 


app.Run();
