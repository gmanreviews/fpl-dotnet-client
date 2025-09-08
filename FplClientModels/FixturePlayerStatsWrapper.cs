namespace FplClientModels;

[UsedImplicitly]
public class FixturePlayerStatsWrapper
{
    [JsonPropertyName("elements")] 
    public PlayerFixtureDetails[] PlayerStats { get; set; } = [];
}