using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public static IServiceCollection AddLogger(this IServiceCollection services)
        {
            return services;
        }
    }
}
