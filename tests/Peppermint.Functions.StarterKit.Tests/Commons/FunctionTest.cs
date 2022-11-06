using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;


namespace Peppermint.Functions.StarterKit.Tests.Commons
{
    public class FunctionTest<TFunction>
        where TFunction : class
    {
        private readonly IServiceCollection servicesCollection = new ServiceCollection();
        private IServiceProvider provider;
        public ILogger Logger { get; set; }

        public TFunction Function {
            get 
            { 
                return provider.GetService<TFunction>(); 
            } 
        }

        public FunctionTest()
        {
            Logger = Mock.Of<ILogger>();
            RegisterServices();
            BuildServices();
        }

        private void RegisterServices()
        {
            servicesCollection.AddSingleton<ILogger>(Logger);
            servicesCollection.AddTransient<TFunction>();
        }

        private void BuildServices()
        {
            provider = servicesCollection.BuildServiceProvider();
        }
    }
}
