using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfacies;
using Repository.Implementation;
using Business.Interfacies;
using Business.Implemenation;
namespace Api.Extention
{
    public static class ConfigurationService
    {
        public static void SqlConfigurationService(this IServiceCollection services,IConfiguration  confg)
        {
              services.AddDbContext<AppDbContext>(opt=>
                        opt.UseSqlServer(confg.GetConnectionString("sqlConnection"),
                                                            b=>b.MigrationsAssembly("API"))); 
              services.AddSingleton<DapperContext>(s => new DapperContext(confg.GetConnectionString("sqlConnection")));
                 
        }
        public static void addServicesRepo(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepo<>),typeof(GenericRepo<>));
            services.AddScoped(typeof(ILanguageRepo),typeof(LanguageRepo));
            services.AddScoped(typeof(IMangerRepo),typeof(MangerRepo));
        }
         public static void addServicesServ(this IServiceCollection services)
        {
            services.AddScoped(typeof(ILanguageServes),typeof(LanguageServes));
        }
    }
}