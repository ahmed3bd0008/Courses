using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Api.Extention;
using Repository.Context;
using Business.Mapper;
using Newtonsoft.Json.Serialization;

namespace API
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
  services.AddControllers();
        //     services.AddControllers().AddJsonOptions(options => {
        //         // set this option to TRUE to indent the JSON output
        //         options.JsonSerializerOptions.WriteIndented = true;
        //         // set this option to NULL to use PascalCase instead of
        //         // camelCase (default)
        //         // options.JsonSerializerOptions.PropertyNamingPolicy =
        //         // null;; 
        //     //options =>
        //   //  {
        //     //    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
        //     //}
        //     });
            
           //add Swagger
           services.addSwaggerService();
           //add sqlConnection
            services.SqlConfigurationService(Configuration);
            //add Identity
            services.addServiceIdentity(configuration:Configuration);
            //Add JWT
            services.addServicesJwt(configuration:Configuration);
            services.addServicesRepo();
            services.addServicesServ();
            services.AddAutoMapper(typeof(ConfigurationMapper));
            services.AddHealthChecks();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));


            }
            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = (context) =>
                {
                    // Disable caching for all static files.
                   context.Context.Response.Headers["Cache-Control"] =
                            Configuration["StaticFiles:Headers:Cache-Control"];
                }
            });
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(Op=>Op.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
