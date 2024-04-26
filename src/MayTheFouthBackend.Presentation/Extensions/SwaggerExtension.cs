using Microsoft.OpenApi.Models;

namespace MayTheFouthBackend.Presentation.Extensions;

public static class SwaggerExtension
{
    public static void AddSwaggerGenService(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "May The Fourth Backend",
                Description = "Challeng Backend code for Star wors Day",
            });
        });
    }
    public static void useSwaggerApp(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger(options =>
            {
                options.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint($"/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
