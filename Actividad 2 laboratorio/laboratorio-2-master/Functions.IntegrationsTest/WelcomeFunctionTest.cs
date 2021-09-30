using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Functions.IntegrationsTest
{
    [Collection(nameof(FunctionTestCollections))]
    public class WelcomeFunctionTest
    {
        private FunctionTestFixture testFixture;
        private HttpResponseMessage responseMessage;

        public  WelcomeFunctionTest(FunctionTestFixture fixture)
        {
            testFixture = fixture;
        }

        [Fact]
        public async Task TestWhenFuctionisInvoked()
        {
            responseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Practica+Martin");
            Assert.True(responseMessage.IsSuccessStatusCode);
        }

    }
}
