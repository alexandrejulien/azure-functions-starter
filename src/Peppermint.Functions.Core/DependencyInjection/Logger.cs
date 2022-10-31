using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peppermint.Functions.Core.DependencyInjection
{
    public static class Logger
    {
        public static IServiceCollection AddLogger(this IServiceCollection services)
        {
            services.AddLogging();

            return services;
        }
    }
}
