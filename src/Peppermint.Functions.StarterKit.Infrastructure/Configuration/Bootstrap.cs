using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Peppermint.Functions.Infrastructure.DependencyInjection
{
    /// <summary>
    /// Bootstraper.
    /// </summary>
    public static class Bootstrap
    {
        /// <summary>
        /// Adds the bootstraper.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddBootstrap(this IServiceCollection services)
        {
            services.AddLogger();
            return services;
        }
    }
}
