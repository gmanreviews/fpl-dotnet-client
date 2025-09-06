using System.Text.Json;
using Bogus;
using FplClient;
using FplClientModels;
using Moq;
using RichardSzalay.MockHttp;
using static FplClientTests.EmbeddedData;

namespace FplClientTests;

public class ClientTests
{
    private readonly Mock<IHttpClientFactory> clientFactory = new();
    private readonly MockHttpMessageHandler mockHttp = new();
    private readonly Client client;
    private readonly string baseUrl;
    private readonly Faker faker = new ();

    public ClientTests()
    {
        baseUrl = faker.Internet.Url();
        client = new Client(clientFactory.Object);
        var httpClient = mockHttp.ToHttpClient();
        httpClient.BaseAddress = new Uri(baseUrl);
        clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(httpClient);
    }

    [Fact]
    public async Task TestGetAllFixtures()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
      
        mockHttp.When($"{baseUrl}/api/fixtures/")
          .Respond("application/json", readText);
        
        var actual = await client.GetAllFixtures(CancellationToken.None);
        Assert.NotEmpty(actual);
    }
    
    [Fact]
    public async Task TestGetAllFixturesWithGameweek()
    {
        var eventId = faker.Random.Int(1, 38);
        
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
        
        var fixtures = JsonSerializer.Deserialize<Fixture[]>(readText) ?? [];
        var limitedFixtures = fixtures.Where(f => f.Event == eventId).ToList();
        var textFixtures = JsonSerializer.Serialize(limitedFixtures);
        
        
        mockHttp.When($"{baseUrl}/api/fixtures/?event={eventId}")
            .Respond("application/json", textFixtures);
        
        var actual = await client.GetAllFixtures(eventId, CancellationToken.None);
        Assert.NotEmpty(actual);
    }
    
    [Fact]
    public async Task TestGetGenericDataSet()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.bootstrap-static.json");
      
        mockHttp.When($"{baseUrl}/api/bootstrap-static/")
            .Respond("application/json", readText);
        
        var actual = await client.GetGenericDataSet(CancellationToken.None);
        Assert.NotNull(actual);
    }
    
    [Fact]
    public async Task TestPlayerDetails()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.element-summary.json");
        var playerId = faker.Random.Int(1, 38);
        
        mockHttp.When($"{baseUrl}/api/element-summary/{playerId}/")
            .Respond("application/json", readText);
        
        var actual = await client.GetPlayerDetails(playerId, CancellationToken.None);
        Assert.NotNull(actual);
    }
    
    [Fact]
    public async Task TestGetPlayerStatsForGameWeek()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.event-live.json");
        var gameweek = faker.Random.Int(1, 38);
        
        mockHttp.When($"{baseUrl}/api/event/{gameweek}/live")
            .Respond("application/json", readText);
        
        var actual = await client.GetPlayerStatsForGameWeek(gameweek, CancellationToken.None);
        Assert.NotNull(actual);
    }
}