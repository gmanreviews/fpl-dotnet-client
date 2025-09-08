namespace FplClientModels;

public class ManagerStats
{
    [JsonPropertyName("current")] 
    public CurrentSeasonHistory[] CurrentSeasonStats { get; set; } = [];
    [JsonPropertyName("past")]
    public PastSeasonOverview[] PastSeasonStats { get; set; } = [];
    //need to find example of this
    //[JsonPropertyName("chips")]
}