using AutoMapper;
using BancoAPI.Api.Configurations;
using BancoAPI.Application.Logger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System;
using System.IO;

namespace BancoAPI.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Adicionando o contexto com a string de conexão
            services.AddDatabaseConfig(Configuration);

            // Adicionando AutoMapper para DTOs
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Adicionando os controladores e o contract resolver do newtonsoft para realizar operações PATCH
            services.AddPatchConfig();

            // Configuração padrão do Swagger/OpenAPI
            services.AddSwaggerConfig();

            // Registrando os serviços de injeção de dependência dos repositórios
            services.AddDependencyInjectionConfig();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerManager logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BancoAPI.Api v1"));
            }

            app.ConfigureExceptionHandler(logger);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}