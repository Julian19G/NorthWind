using Microsoft.Extensions.DependencyInjection;
using NorthWind.Core;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
        {
            services.AddDebugWriter();
            services.AddConsoleWriter();
            services.AddFileWriter();
            services.AddServices();
            return services;
        }
    }
}
