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
    /// Starter kit.
    /// </summary>
    public static class StarterKit
    {
        /// <summary>
        /// Adds the starter kit.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddStarterKit(this IServiceCollection services)
        {
            services.AddLogger();
            return services;
        }
    }
}
