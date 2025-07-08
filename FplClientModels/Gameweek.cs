using System.Text.Json.Serialization;

namespace FplClientModels;

[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public class Gameweek
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
    
}