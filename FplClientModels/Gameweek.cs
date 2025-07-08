using System.Text.Json.Serialization;

namespace FplClientModels;

[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public class Gameweek
{
    [JsonPropertyName("code")]
    public long Code;
    [JsonPropertyName("event")]
    public int Event;
    [JsonPropertyName("finished")]
    public bool Finished;
    [JsonPropertyName("finished_provisional")]
    public bool FinishedProvisionally;
    [JsonPropertyName("id")]
    public long Id;
    [JsonPropertyName("kickoff_time")]
    public DateTimeOffset KickoffTime;
    [JsonPropertyName("minutes")]
    public int Minutes;
    
}