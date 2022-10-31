using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Peppermint.Functions.Core.DependencyInjection
{
    public static class StarterKit
    {
        public static IServiceCollection AddStarterKit(this IServiceCollection services)
        {
            services.AddLogger();

            return services;
        }
    }
}
