using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Moq;
using Peppermint.Functions.Infrastructure.DependencyInjection;
using System.Configuration;

namespace Peppermint.Functions.StarterKit.Tests.Abstracts
{
    /// <summary>
    /// Abstract class function test.
    /// </summary>
    /// <typeparam name="TFunction">The type of the function.</typeparam>
    public abstract class BaseFunctionTest<TFunction>
        where TFunction : class
    {
        /// <summary>
        /// The services collection
        /// </summary>
        private readonly IServiceCollection servicesCollection = new ServiceCollection();

        /// <summary>
        /// The provider
        /// </summary>
        private IServiceProvider provider;

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Gets the function.
        /// </summary>
        /// <value>
        /// The function.
        /// </value>
        public TFunction Function => provider.GetService<TFunction>();

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFunctionTest{TFunction}"/> class.
        /// </summary>
        public BaseFunctionTest()
        {
            Logger = Mock.Of<ILogger>();

            Configure();
            RegisterServices();
            provider = servicesCollection.BuildServiceProvider();
        }

        /// <summary>
        /// Registers the services.
        /// </summary>
        private void RegisterServices()
        {
            servicesCollection.AddSingleton<ILogger>(Logger);
            servicesCollection.AddTransient<TFunction>();
            servicesCollection.AddBootstrap(Configuration);
        }

        /// <summary>
        /// Configures this instance.
        /// </summary>
        private void Configure()
        {
            var config = new ConfigurationBuilder()
                                 .AddEnvironmentVariables()
                                 .AddJsonFile("host.json")
                                 .Build();

            var startup = new Startup();

            var host = WebHost.CreateDefaultBuilder()
                        .UseStartup<Startup>()
                        .UseConfiguration(config);


            Configuration = config;
        }
    }
}
