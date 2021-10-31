using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Repository.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfacies;
using Repository.Implementation;
using Business.Interfacies;
using Business.Implemenation;
using Core.Entity.User;
using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Business.Interfacies.Authencation;
using Business.Implemenation.authentication;

namespace Api.Extention
{
    public static class ConfigurationService
    {
        public static void SqlConfigurationService(this IServiceCollection services,IConfiguration  confg)
        {
              services.AddDbContext<AppDbContext>(opt=>
                        opt.UseSqlServer(confg.GetConnectionString("sqlConnection"),
                                                            b=>b.MigrationsAssembly("API")));
       //Ddapper conection To dataBase
            services.AddSingleton<DapperContext>(s => new DapperContext(confg.GetConnectionString("sqlConnection")));
            //add identity 
            


        }
        public static void addServiceIdentity(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddIdentity<AppUser, AppRole>(Option => { Option.SignIn.RequireConfirmedAccount = false; Option.SignIn.RequireConfirmedEmail = false; }).
            AddEntityFrameworkStores<AppDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 2;
                options.Password.RequiredUniqueChars = 0;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
        services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                //options.LoginPath = "/Identity/Account/Login";
                //options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
        }
         public static void addServicesJwt(this IServiceCollection services,IConfiguration configuration)
            {
                 IConfigurationSection JwtSetting=configuration.GetSection("JwtSettings");
            services.AddAuthentication(opt => 
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(Options=>{
                Options.SaveToken = true;
                var key = Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"].ToString());
                var secret = new SymmetricSecurityKey(key);
                Options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = JwtSetting.GetSection("validIssuer").Value,
                    ValidAudience = JwtSetting.GetSection("validAudience").Value,
                    IssuerSigningKey = secret,
                    RequireExpirationTime=false
                };

            });
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
            services.AddScoped(typeof(IAuthentcationManger),typeof(AuthentcationManger));
            
        }
        
    }
}