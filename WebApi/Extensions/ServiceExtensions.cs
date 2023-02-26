using Microsoft.AspNetCore.Mvc;

namespace WebApi.Extensions
{
    //clase de extension para el versionado de la Api
    public static class ServiceExtensions
    {
        public static void AddApiVersioningExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);

                config.AssumeDefaultVersionWhenUnspecified = true; //Si el cliente no especifica la version por defecto será la 1.0

                config.ReportApiVersions = true;
            });
        }
    }
}
