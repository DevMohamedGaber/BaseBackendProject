namespace Presentation.Extentions;

public static class CorsExtensions
{
    public static void AddCorsBehavior(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder => builder.AllowAnyOrigin()
                                                       .AllowAnyMethod()
                                                       .AllowAnyHeader());
        });
    }
}
