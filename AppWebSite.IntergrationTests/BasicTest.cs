using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AppWebSite.IntergrationTests
{
    public class BasicTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        public readonly WebApplicationFactory<Startup> _factory;

        public BasicTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Encuestas/index")]
        [InlineData("/Encuestas/create")]
        public async Task GetHttpRequest(string url)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);

            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());

        }
    }
}
