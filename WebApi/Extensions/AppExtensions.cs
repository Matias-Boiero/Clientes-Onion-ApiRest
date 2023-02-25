using WebApi.Middlewares;

namespace WebApi.Extensions
{
    //Extension de la clase ErrorHanderMiddlewares para inyectar el App.Use en el program de esta clase manejadora
    //de excepciones
    public static class AppExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddlewares>();
        }
    }
}
