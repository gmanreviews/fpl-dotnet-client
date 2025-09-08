namespace FplClientModels;

[UsedImplicitly]
public class ClassicLeague
{
    [JsonPropertyName("admin_entry")]
    public int? AdminEntry { get; set; }
    [JsonPropertyName("closed")]
    public bool Closed { get; set; }
    [JsonPropertyName("created")]
    public string? Created { get; set; }
    [JsonPropertyName("cup_league")]
    public bool? CupLeague { get; set; }
    [JsonPropertyName("cup_qualified")]
    public bool? CupQualified { get; set; }
    [JsonPropertyName("entry_can_admin")]
    public bool CanAdmin { get; set; }
    [JsonPropertyName("entry_can_invite")]
    public bool CanInvite { get; set; }
    [JsonPropertyName("entry_can_leave")]
    public bool CanLeave { get; set; }
    [JsonPropertyName("entry_percentile_rank")]
    public int? PercentileRank { get; set; }
    [JsonPropertyName("entry_rank")]
    public int EntryRank { get; set; }
    [JsonPropertyName("has_cup")]
    public bool HasCup { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("league_type")]
    public string? LeagueType { get; set; } //to figure out an enum for this
    [JsonPropertyName("max_entries")]
    public int? MaxEntries { get; set; }
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }
    [JsonPropertyName("rank_count")]
    public int? RankCount { get; set; }
    [JsonPropertyName("scoring")]
    public string? Scoring { get; set; }
    [JsonPropertyName("short_name")]
    public string? ShortName { get; set; }
    [JsonPropertyName("start_event")]
    public int StartingEvent { get; set; }
}