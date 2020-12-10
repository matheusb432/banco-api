using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace BancoAPI.Api.Configurations
{
    public static class PatchConfig
    {
        public static void AddPatchConfig(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(s =>
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
        }
    }
}