using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Data;

namespace Tests.Service
{
    public static class InjectionService
    {

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            return services;
        }
    }
}
