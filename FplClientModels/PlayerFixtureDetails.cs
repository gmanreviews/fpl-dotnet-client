using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class PlayerFixtureDetails : PlayerStatsDetails
{
    [JsonPropertyName("element")]
    public int Element { get; set; }
    [JsonPropertyName("fixture")]
    public int Fixture { get; set; }
    [JsonPropertyName("kickoff_time")]
    public string? KickoffTime { get; set; }
    [JsonPropertyName("round")]
    public int Round { get; set; }
    [JsonPropertyName("selected")]
    public int Selected { get; set; }
    [JsonPropertyName("team_a_score")]
    public int AwayScore { get; set; }
    [JsonPropertyName("team_h_score")]
    public int HomeScore { get; set; }
    [JsonPropertyName("transfers_balance")]
    public int TransfersBalance { get; set; }
    [JsonPropertyName("transfers_in")]
    public int TransfersIn { get; set; }
    [JsonPropertyName("transfers_out")]
    public int TransfersOut { get; set; }
    [JsonPropertyName("value")]
    public int Value { get; set; }
    [JsonPropertyName("was_home")]
    public bool? WasHome { get; set; }
}