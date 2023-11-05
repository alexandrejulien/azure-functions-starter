using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Peppermint.Functions.Infrastructure.DependencyInjection
{
    /// <summary>
    /// Logging extensions.
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        /// Adds the logger.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>Service collection.</returns>
        public static IServiceCollection AddLogger(this IServiceCollection services, 
                                                        IConfiguration configuration)
        {
            services.AddLogging(logging =>
            {
                logging.AddConfiguration(configuration.GetSection("logging"));
                logging.AddConsole();
            });
            return services;
        }
    }
}
