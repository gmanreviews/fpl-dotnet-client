using System.Text.Json;
using Bogus;
using FplClient;
using FplClientModels;
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
    public async Task TestGetAllFixtures()
    {
        var readText = EmbeddedData.ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
      
        mockHttp.When("https://fantasy.premierleague.com/api/fixtures/")
          .Respond("application/json", readText);
        
        var actual = await client.GetAllFixtures(CancellationToken.None);
        Assert.NotEmpty(actual);
    }
    
    [Fact]
    public async Task TestGetAllFixturesWithGameweek()
    {
        var eventId = new Faker().Random.Int(1, 38);
        
        var readText = EmbeddedData.ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
        
        var fixtures = JsonSerializer.Deserialize<Fixture[]>(readText) ?? [];
        var limitedFixtures = fixtures.Where(f => f.Event == eventId).ToList();
        var textFixtures = JsonSerializer.Serialize(limitedFixtures);
        
        
        mockHttp.When($"https://fantasy.premierleague.com/api/fixtures/?event={eventId}")
            .Respond("application/json", textFixtures);
        
        var actual = await client.GetAllFixtures(eventId, CancellationToken.None);
        Assert.NotEmpty(actual);
    }
}