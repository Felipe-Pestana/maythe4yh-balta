using MayTheFouthBackend.Presentation.Extensions;
using MayTheFouthBackend.Infra.IOC.DependencyInjection; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.AddSwaggerGenService();

builder.Services.AddRegisterService(); 
builder.Services.AddDatabaseService(builder.Configuration);
builder.Services.AddPlanetService(); 


var app = builder.Build();

app.useSwaggerApp(); 

app.UseHttpsRedirection();

app.MapPlanetEndpoint(); 

app.Run();

