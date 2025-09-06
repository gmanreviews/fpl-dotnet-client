using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class PlayerSeasonDetails : PlayerStatsDetails
{
    [JsonPropertyName("element_code")]
    public int ElementCode { get; set; }
    [JsonPropertyName("end_cost")]
    public int EndCost { get; set; }
    [JsonPropertyName("season_name")]
    public required string SeasonName { get; set; }
    [JsonPropertyName("start_cost")]
    public int StartCost { get; set; }
}