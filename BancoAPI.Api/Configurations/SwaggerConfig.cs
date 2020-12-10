using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BancoAPI.Api.Configurations
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BancoAPI.Api", Version = "v1" });
            });
        }
    }
}