using AutoMapper;
using BancoAPI.Application.Repositories.ModelRepos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using SistemaBanco.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoAPI.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Adicionando o contexto com a string de conexão
            services.AddDbContext<BancoContext>(options => options.UseSqlServer
                (Configuration.GetConnectionString("BancoConnection")));

            // Adicionando AutoMapper para DTOs
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Adicionando os controladores e o contract resolver do newtonsoft para realizar operações PATCH
            services.AddControllers().AddNewtonsoftJson(s =>
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

            // Configuração padrão do Swagger/OpenAPI
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BancoAPI.Api", Version = "v1" });
            });

            // Registrando os serviços de injeção de dependência dos repositórios
            services.AddScoped<AfiliadosRepo>();
            services.AddScoped<ClientesRepo>();
            services.AddScoped<ContasRepo>();
            services.AddScoped<CorretorasRepo>();
            services.AddScoped<FuncionariosRepo>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BancoAPI.Api v1"));
            }

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
