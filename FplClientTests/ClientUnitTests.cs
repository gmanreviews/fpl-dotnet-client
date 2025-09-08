using System.Text.Json;
using FplClient;
using FplClientModels;
using Moq;
using RichardSzalay.MockHttp;
using static FplClientTests.EmbeddedData;

namespace FplClientTests;

public class ClientUnitTests: ClientTests
{
    private readonly Mock<IHttpClientFactory> clientFactory = new();
    private readonly MockHttpMessageHandler mockHttp = new();
    private readonly string baseUrl;
    
    
    public ClientUnitTests()
    {
        baseUrl = Faker.Internet.Url();
        Client = new Client(clientFactory.Object);
        var httpClient = mockHttp.ToHttpClient();
        httpClient.BaseAddress = new Uri(baseUrl);
        clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(httpClient);
    }

    protected override Client Client { get; }

    public override async Task TestGetAllFixtures()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
      
        mockHttp.When($"{baseUrl}/api/fixtures/")
            .Respond("application/json", readText);

        await base.TestGetAllFixtures();
    }
    
    public override async Task TestGetAllFixturesWithGameweek()
    {
        var eventId = Faker.Random.Int(1, 38);
        
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.fixtures.json");
        
        var fixtures = JsonSerializer.Deserialize<Fixture[]>(readText) ?? [];
        var limitedFixtures = fixtures.Where(f => f.Event == eventId).ToList();
        var textFixtures = JsonSerializer.Serialize(limitedFixtures);
        
        
        mockHttp.When($"{baseUrl}/api/fixtures/?event={eventId}")
            .Respond("application/json", textFixtures);
        
        await TestGetAllFixturesWithGameweekWithEventId(eventId);
    }
    
    public override async Task TestGetGenericDataSet()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.bootstrap-static.json");
      
        mockHttp.When($"{baseUrl}/api/bootstrap-static/")
            .Respond("application/json", readText);

        await base.TestGetGenericDataSet();
    }
    
    public override async Task TestPlayerDetails()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.element-summary.json");
        var playerId = Faker.Random.Int(1, 38);
        
        mockHttp.When($"{baseUrl}/api/element-summary/{playerId}/")
            .Respond("application/json", readText);
        
        await  TestPlayerDetailsWithPlayerId(playerId);
    }
    
    public override async Task TestGetPlayerStatsForGameWeek()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.event-live.json");
        var gameweek = Faker.Random.Int(1, 38);
        
        mockHttp.When($"{baseUrl}/api/event/{gameweek}/live")
            .Respond("application/json", readText);
        
        await TestGetPlayerStatsForGameWeekWithGameweek(gameweek);
    }

    public override async Task TestGetManagerSummary()
    {
        var readText = ReadEmbeddedData<ClientTests>("FplClientTests.TestData.manager.json");
        var managerId = Faker.Random.Int(1, 38);
        
        mockHttp.When($"{baseUrl}/api/entry/{managerId}/")
            .Respond("application/json", readText);
        
        await TestGetManagerSummaryWithGameweek(managerId);
    }
}