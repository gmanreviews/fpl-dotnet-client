using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class Team
{
    [JsonPropertyName("code")]
    public int Code { get; set; }
    [JsonPropertyName("draw")]
    public int Draws { get; set; }
    [JsonPropertyName("form")]
    public string? Form { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("loss")]
    public int Losses { get; set; }
    [JsonPropertyName("played")]
    public int GamesPlayed { get; set; }
    [JsonPropertyName("points")]
    public int Points { get; set; }
    [JsonPropertyName("position")]
    public int Position { get; set; }
    [JsonPropertyName("short_name")]
    public required string ShortName { get; set; }
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
    [JsonPropertyName("team_division")]
    public string? TeamDivision { get; set; }
    [JsonPropertyName("unavailable")]
    public bool Unavailable { get; set; }
    [JsonPropertyName("win")]
    public int Wins { get; set; }
    [JsonPropertyName("strength_overall_home")]
    public int HomeStrengthOverall { get; set; }
    [JsonPropertyName("strength_overall_away")]
    public int AwayStrengthOverall { get; set; }
    [JsonPropertyName("strength_attack_home")]
    public int HomeStrengthAttack { get; set; }
    [JsonPropertyName("strength_attack_away")]
    public int AwayStrengthAttack { get; set; }
    [JsonPropertyName("strength_defense_home")]
    public int HomeStrengthDef { get; set; }
    [JsonPropertyName("strength_defense_away")]
    public int AwayStrengthDef { get; set; }
    [JsonPropertyName("pulse_id")]
    public int PulseId { get; set; }
}
