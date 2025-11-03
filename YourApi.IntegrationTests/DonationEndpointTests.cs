using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Threading.Tasks;

namespace YourApi.IntegrationTests
{
    [TestClass]
    public class DonationEndpointTests
    {
        private WebApplicationFactory<Program> _factory;

        [TestInitialize]
        public void Setup() => _factory = new WebApplicationFactory<Program>();

        [TestMethod]
        public async Task GetTotal_Returns11()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/Donation/5/6");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var content = await response.Content.ReadAsStringAsync();
            Assert.AreEqual("11", content);
        }

        private class WebApplicationFactory<T>
        {
            internal object CreateClient() => throw new NotImplementedException();
        }
    }
}
