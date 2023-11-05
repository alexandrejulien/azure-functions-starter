using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using Peppermint.Functions.Infrastructure.DependencyInjection;

namespace Peppermint.Functions.StarterKit.Tests.Commons
{
    /// <summary>
    /// Abstract class function test.
    /// </summary>
    /// <typeparam name="TFunction">The type of the function.</typeparam>
    public abstract class FunctionTest<TFunction>
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
        /// Initializes a new instance of the <see cref="FunctionTest{TFunction}"/> class.
        /// </summary>
        public FunctionTest()
        {
            Logger = Mock.Of<ILogger>();
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
            servicesCollection.AddBootstrap();
        }
    }
}
