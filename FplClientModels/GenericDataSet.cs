using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class GenericDataSet
{
    [JsonPropertyName("chips")]
    public required Chip[] Chips {get; set;}
    [JsonPropertyName("events")]
    public required Fixture[] Fixtures {get; set;}
    [JsonPropertyName("teams")]
    public required Team[] Teams {get; set;}
    
}