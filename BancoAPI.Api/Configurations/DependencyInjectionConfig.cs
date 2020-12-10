using BancoAPI.Application.Logger;
using BancoAPI.Application.Repositories.ModelRepos;
using Microsoft.Extensions.DependencyInjection;

namespace BancoAPI.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<AfiliadosRepo>();
            services.AddScoped<ClientesRepo>();
            services.AddScoped<ContasRepo>();
            services.AddScoped<CorretorasRepo>();
            services.AddScoped<FuncionariosRepo>();

            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}