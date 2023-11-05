using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using NFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peppermint.Functions.StarterKit.Tests
{
    /// <summary>
    /// Startup class tests.
    /// </summary>
    [TestClass]
    public class StartupTests
    {
        /// <summary>
        /// Givens the startup check register ok.
        /// </summary>
        [TestCategory("Infrastructure")]
        [TestMethod]
        public void Given_Startup_CheckRegisterOk()
        {
            var startup = new Startup();
            Check.That(startup).InheritsFrom<FunctionsStartup>();

            var host = Mock.Of<IFunctionsHostBuilder>();
            startup.Configure(host);
        }
    }
}
