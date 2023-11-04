using azure_functions_starter.Functions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Primitives;
using Moq;
using Peppermint.Functions.StarterKit.Tests.Commons;
using System.Text;

namespace Peppermint.Functions.StarterKit.Tests.Functions
{
    /// <summary>
    /// Http Starter Test.
    /// </summary>
    /// <seealso cref="FunctionTest&lt;HttpStarterFunction&gt;" />
    [TestClass]
    public class HttpStarterFunctionsTest
        : FunctionTest<HttpStarterFunction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpStarterFunctionsTest"/> class.
        /// </summary>
        public HttpStarterFunctionsTest()
        {

        }

        /// <summary>
        /// Givens the HTTP request when trigger function then check function run.
        /// </summary>
        [TestMethod]
        public void Given_HttpRequest_WhenTriggerFunction_Then_CheckFunctionRun()
        {
            var requestMock = new Mock<HttpRequest>();
            requestMock.
                Setup(x => x.Query["name"])
                .Returns("test_argument");
            requestMock
                .SetupGet(x => x.Body)
                .Returns(new MemoryStream(Encoding.UTF8.GetBytes("{ \"ok\": \"fine\" }")));

            Function.Run(requestMock.Object, Logger).Wait();
        }
    }
}