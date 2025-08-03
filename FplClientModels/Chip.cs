using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class Chip
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("number")]
    public required int Number { get; set; }
    [JsonPropertyName("start_event")]
    public required int StartEvent {get; set;}
    [JsonPropertyName("stop_event")]
    public required int EndEvent {get; set;}
    [JsonPropertyName("chip_type")]
    public required string Type { get; set; }
}