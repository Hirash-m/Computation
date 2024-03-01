using Application;
using Application.Contracts.Person;
using Computation.UI.MainData.Person;
using Infrastructure.IRepository;
using Infrastructure.Models;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation.UI
{
    public class Boot
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<ComputationContext>();
            services.AddTransient<IPersonApp, PersonApp>();
            services.AddTransient<IPersonRepository, PersonRepository>();

            services.AddTransient<MainForm>();
            services.AddTransient<PersonForm>();

        }
    }
}
