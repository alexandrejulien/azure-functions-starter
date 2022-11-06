using Peppermint.Functions.StarterKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Primitives;
using Moq;
using Peppermint.Functions.StarterKit.Tests.Commons;

namespace Peppermint.Functions.StarterKit.Tests
{
    [TestClass]
    public class HttpStarterTest : FunctionTest<HttpStarterFunction>
    {
        [TestMethod]
        public void TestStarter()
        {
            var request = Mock.Of<HttpRequest>();
            Function.Run(request, Logger).Wait();
        }
    }
}