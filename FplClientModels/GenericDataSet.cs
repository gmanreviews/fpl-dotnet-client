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
    [JsonPropertyName("elements")]
    public required PlayerDetails[] Players {get; set;}
}
