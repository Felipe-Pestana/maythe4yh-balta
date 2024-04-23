using MayTheFouthBackend.Presentation.Extensions;
using MayTheFouthBackend.Infra.IOC.DependencyInjection; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRegisterService(); 
builder.Services.AddDatabaseService(builder.Configuration);
builder.Services.AddPlanetService(); 


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPlanetEndpoint(); 

app.Run();

