namespace FplClientModels;

[UsedImplicitly]
public class Leagues
{
    [JsonPropertyName("classic")]
    public ClassicLeague[] ClassicLeague { get; set; } = [];
}