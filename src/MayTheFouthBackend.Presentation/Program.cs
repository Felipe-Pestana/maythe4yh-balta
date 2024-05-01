
using MayTheFouthBackend.Infra.IOC.DependencyInjection;
using MayTheFouthBackend.Presentation.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.AddSwaggerGenService();

builder.Services.AddAllServices(builder.Configuration);

builder.AddCorsPolicy(builder.Configuration);

var app = builder.Build();

app.useSwaggerApp();

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin"); 

app.MapPlanetEndpoint();
app.MapStarshipEndpoint();
app.MapCharacterEndpoint();
app.MapMovieEndpoint();
app.MapVehicleEndpoint(); 


app.Run();
