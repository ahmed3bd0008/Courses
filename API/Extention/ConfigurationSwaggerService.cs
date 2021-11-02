using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Api.Extention
{
    public static class ConfigurationSwaggerService
    {
        public static void addSwaggerService(this IServiceCollection services)
        {
                     services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                c.SwaggerDoc("v2", new OpenApiInfo { Title = "Code Maze API", Version = "v2" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Place to add JWT with Bearer",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                 c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                    {
                    {
                        new OpenApiSecurityScheme
                    {
                            Reference = new OpenApiReference
                    {
                                Type = ReferenceType.SecurityScheme, Id = "Bearer" },
                                     Name = "Bearer", }, new List<string>()
                     }
                     });
            });
        }
    }
}