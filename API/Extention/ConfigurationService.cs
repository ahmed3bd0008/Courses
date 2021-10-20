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
            services.AddScoped(typeof(ICurrencyRepo),typeof(CurrencyRepo));
            services.AddScoped(typeof(IMangerRepo),typeof(MangerRepo));
            services.AddScoped(typeof(ICourseLevelRepo),typeof(CourseLevelRepo));
            services.AddScoped(typeof(ICourseStatuseRepo),typeof(CourseStatuseRepo));
            services.AddScoped(typeof(ICourseTypeRepo),typeof(CourseTypeRepo));
            services.AddScoped(typeof(ICourseRepo),typeof(CourseRepo));
            services.AddScoped(typeof(IInstructorRepo),typeof(InstructorRepo));
            services.AddScoped(typeof(IModuleRepo),typeof(ModuleRepo));
            services.AddScoped(typeof(ISkillRepo),typeof(SkillRepo));
        }
         public static void addServicesServ(this IServiceCollection services)
        {
            services.AddScoped(typeof(ISystemService),typeof(SystemService));
            services.AddScoped(typeof(ISystemServiceCourse),typeof(SystemServiceCourse));
            services.AddScoped(typeof(ICourseServices),typeof(CourseServices));
            services.AddScoped(typeof(ICourseAssistant),typeof(CourseAssistant));
        }
    }
}