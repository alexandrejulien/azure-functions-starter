using Microsoft.Extensions.Configuration;
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
        /// Adds the bootstrap.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>Service collection.</returns>
        public static IServiceCollection AddBootstrap(this IServiceCollection services,
                                                           IConfiguration configuration)
        {
            services.AddLogger(configuration);
            return services;
        }
    }
}
