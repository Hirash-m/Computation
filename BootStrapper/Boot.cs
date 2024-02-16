using Application;
using Application.Contracts.Person;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace BootStrapper
{
    public class Boot
    { 
        public static void Configure(IServiceCollection services)
        {

            services.AddTransient<IPersonApp, PersonApp>();
            services.AddTransient<IPersonRepository, PersonRepositoey>();
            services.AddTransient<System.Windows.Forms.Form>();
        }
    }
}
