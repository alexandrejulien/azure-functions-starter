using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Peppermint.Functions.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azure_functions_starter
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddStarterKit();
        }
    }
}
