using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaBanco.Infra;

namespace BancoAPI.Api.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BancoContext>(options => options.UseSqlServer
                (configuration.GetConnectionString("BancoConnection")));
        }
    }
}