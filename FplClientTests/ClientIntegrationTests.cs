using FplClient;
using Moq;

namespace FplClientTests;

[Trait("Category", "Integration")]
public class ClientIntegrationTests: ClientTests
{
    private readonly Mock<IHttpClientFactory> httpClientFactory = new();
    
    public ClientIntegrationTests()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://fantasy.premierleague.com/");
        httpClientFactory.Setup(f => f.CreateClient(It.IsAny<string>())).Returns(httpClient);
        Client = new Client(httpClientFactory.Object);
    }
    
    protected override Client Client { get; }
    
    public override async Task TestGetAllFixturesWithGameweek()
    {
        var eventId = Faker.Random.Int(1, 38);
        
        await TestGetAllFixturesWithGameweekWithEventId(eventId);
    }
    
    public override async Task TestPlayerDetails()
    {
        var playerId = Faker.Random.Int(1, 38);
        
        await  TestPlayerDetailsWithPlayerId(playerId);
    }
    
    public override async Task TestGetPlayerStatsForGameWeek()
    {
        var gameweek = Faker.Random.Int(1, 38);
        
        await TestGetPlayerStatsForGameWeekWithGameweek(gameweek);
    }
    
    public override async Task TestGetManagerSummary()
    {
        var managerId = Faker.Random.Int(1, 38);
        await TestGetManagerSummaryWithGameweek(managerId);
    }
}