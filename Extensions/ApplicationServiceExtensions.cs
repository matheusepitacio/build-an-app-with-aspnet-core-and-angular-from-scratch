using DatingApp.API.Data;
using DatingApp.API.Interfaces;
using DatingApp.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using API.Helpers;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions{
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration){
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options => {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

            });

            return services;
        }
    }
}