 namespace MayTheFouthBackend.Presentation.Extensions; 

public static class CorsExtensions
{
    public static void AddCorsPolicy(this WebApplicationBuilder builder, IConfiguration configuration)
    {
        var clientUrl = configuration.GetValue<string>("Cors:ClientUri") ?? string.Empty; 

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: "AllowSpecificOrigin", policy =>
            {
                policy
                .WithOrigins(clientUrl)
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials(); 
            }); 
        }); 
    }
}
