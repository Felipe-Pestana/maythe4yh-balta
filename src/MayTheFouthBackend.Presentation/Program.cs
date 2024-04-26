using MayTheFouthBackend.Infra.Data.Contexts;
using MayTheFouthBackend.Presentation.Extensions;
using Microsoft.EntityFrameworkCore;
using MayTheFouthBackend.Infra.IOC.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAllServices(builder.Configuration);
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPlanetEndpoint();
app.MapStarshipEndpoint();

app.MapPlanetEndpoint(); 
app.MapCharacterEndpoint();


app.Run();

