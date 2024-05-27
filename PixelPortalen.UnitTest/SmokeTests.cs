using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class SmokeTests
{
    [Fact]
    public async Task ApiConnectivityTest()
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync("");
            response.EnsureSuccessStatusCode();
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }

   
}
