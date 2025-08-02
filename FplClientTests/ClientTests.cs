using System.Reflection;
using FplClient;
using Moq;
using RichardSzalay.MockHttp;

namespace FplClientTests;

public class ClientTests
{
    private readonly Mock<IHttpClientFactory> clientFactory = new();
    private readonly MockHttpMessageHandler mockHttp = new();
    private readonly Client client;

    public ClientTests()
    {
        client = new Client(clientFactory.Object);
        clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(mockHttp.ToHttpClient());
    }

    [Fact]
    public async Task TestGameweeks()
    {
        var readText = EmbeddedData.ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
      
        mockHttp.When("https://fantasy.premierleague.com/api/fixtures")
          .Respond("application/json", readText);
        
        var actual = await client.Gameweeks(CancellationToken.None);
        Assert.NotEmpty(actual);
    }
}