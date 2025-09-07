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
    
    [Fact]
    public override async Task TestGetAllFixtures()
    {
        await base.TestGetAllFixtures();
    }
    
    [Fact]
    public override async Task TestGetAllFixturesWithGameweek()
    {
        var eventId = Faker.Random.Int(1, 38);
        
        await TestGetAllFixturesWithGameweekWithEventId(eventId);
    }
    
    [Fact]
    public override async Task TestGetGenericDataSet()
    {
        await base.TestGetGenericDataSet();
    }
    
    [Fact]
    public override async Task TestPlayerDetails()
    {
        var playerId = Faker.Random.Int(1, 38);
        
        await  TestPlayerDetailsWithPlayerId(playerId);
    }
    
    [Fact]
    public override async Task TestGetPlayerStatsForGameWeek()
    {
        var gameweek = Faker.Random.Int(1, 38);
        
        await TestGetPlayerStatsForGameWeekWithGameweek(gameweek);
    }
}