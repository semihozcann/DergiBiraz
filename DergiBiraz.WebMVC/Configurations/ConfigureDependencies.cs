using DergiBiraz.Business.Abstract;
using DergiBiraz.Business.Concrete;
using DergiBiraz.WebMVC.Helpers.Abstract;
using DergiBiraz.WebMVC.Helpers.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DergiBiraz.WebMVC.Configurations
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationManager>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<IFileHelper, FileHelper>();


        }



    }
}
