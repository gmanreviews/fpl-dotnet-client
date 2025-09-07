using Bogus;
using FplClient;

namespace FplClientTests;

public abstract class ClientTests
{
    protected abstract Client Client { get; }
    protected readonly Faker Faker = new ();
    
    public virtual async Task TestGetAllFixtures()
    {
        var actual = await Client.GetAllFixtures(CancellationToken.None);
        Assert.NotEmpty(actual);
    }

    public abstract Task TestGetAllFixturesWithGameweek();
    
    protected async Task TestGetAllFixturesWithGameweekWithEventId(int eventId)
    {
        var actual = await Client.GetAllFixtures(eventId, CancellationToken.None);
        Assert.NotEmpty(actual);
    }
    
    public virtual async Task TestGetGenericDataSet()
    {
        var actual = await Client.GetGenericDataSet(CancellationToken.None);
        Assert.NotNull(actual);
    }
    
    public abstract Task TestPlayerDetails();
    
    protected async Task TestPlayerDetailsWithPlayerId(int playerId)
    {
        var actual = await Client.GetPlayerDetails(playerId, CancellationToken.None);
        Assert.NotNull(actual);
    }
    
    public abstract Task TestGetPlayerStatsForGameWeek();
    
    protected async Task TestGetPlayerStatsForGameWeekWithGameweek(int gameweek)
    {
        var actual = await Client.GetPlayerStatsForGameWeek(gameweek, CancellationToken.None);
        Assert.NotNull(actual);
    }
}