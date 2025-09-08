namespace FplClientModels;

[UsedImplicitly]
public class PastSeasonOverview
{
    [JsonPropertyName("season_name")]
    public required string SeasonName { get; set; }
    [JsonPropertyName("total_points")]
    public int TotalPoints { get; set; }
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
}