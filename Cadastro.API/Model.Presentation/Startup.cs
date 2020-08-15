using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Model.Application;
using Model.Application.Interface;
using Model.Domain.Entities;
using Model.Domain.Interfaces.Repositories;
using Model.Domain.Interfaces.Services;
using Model.Domain.Services;
using Model.Infra.Data.Context;
using Model.Infra.Data.Repositories;
using Model.Presentation.AutoMapper;
using Model.Presentation.Model;

namespace Model.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();

            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            var connection = Configuration["SqlConnection:SqlConnectionString"];
            services.AddDbContext<Contexto>(options => options.UseSqlServer(connection));
            services.AddMemoryCache();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
