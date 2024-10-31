using FastEndpoints;

namespace Presentation.Extentions
{
    public static class FastEndpointsBehaviorExtentions
    {
        public static void AddFastEndpointsBehavior(this IServiceCollection services)
        {
            services.AddFastEndpoints();
        }
    }
}
