using System.Net;
using FplClient;
using Moq;
using RichardSzalay.MockHttp;

namespace FplClientTests;

public class ClientTests
{
    private readonly Mock<IHttpClientFactory> clientFactory = new();
    private readonly MockHttpMessageHandler mockHttp = new();
    private readonly MockedRequest mockRequest = new();
    private readonly Client client;

    public ClientTests()
    {
        client = new Client(clientFactory.Object);

        mockRequest = mockHttp.When("https://fantasy.premierleague.com/api/gameweeks")
            .Respond(HttpStatusCode.OK);
        
        clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(mockHttp.ToHttpClient());
    }

    [Fact]
    public async Task TestGameweeks()
    {
        var actual = await client.Gameweeks();
        Assert.True(true);
    }
}