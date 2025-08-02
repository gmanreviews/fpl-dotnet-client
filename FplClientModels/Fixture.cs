using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class Fixture
{
    [JsonPropertyName("code")]
    public long Code {get; set;}
    [JsonPropertyName("event")]
    public int Event {get; set;}
    [JsonPropertyName("finished")]
    public bool Finished {get; set;}
    [JsonPropertyName("finished_provisional")]
    public bool FinishedProvisionally {get; set;}
    [JsonPropertyName("id")]
    public long Id {get; set;}
    [JsonPropertyName("kickoff_time")]
    public DateTimeOffset KickoffTime {get; set;}
    [JsonPropertyName("minutes")]
    public int Minutes {get; set;}
    [JsonPropertyName("provisional_start_time")]
    public bool ProvisionalStartTime {get; set;}
    [JsonPropertyName("started")]
    public bool Started {get; set;}
    [JsonPropertyName("team_a")]
    public long AwayTeam { get; set; }
    [JsonPropertyName("team_a_score")]
    public int? AwayTeamScore { get; set; }
    [JsonPropertyName("team_a_difficulty")]
    public int AwayTeamDifficulty { get; set; }
    [JsonPropertyName("team_h")]
    public long HomeTeam { get; set; }
    [JsonPropertyName("team_h_score")]
    public int? HomeTeamScore { get; set; }
    [JsonPropertyName("team_h_difficulty")]
    public int HomeTeamDifficulty { get; set; }
    [JsonPropertyName("pulse_id")]
    public long PulseId { get; set; }
}