using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class ElementSummary
{
    [JsonPropertyName("fixtures")] 
    public Fixture[] FutureFixtures { get; set; } = [];
    [JsonPropertyName("history")] 
    public PlayerFixtureDetails[] History { get; set; } = [];
    [JsonPropertyName("history_past")]
    public PlayerSeasonDetails[] HistoryPast { get; set; } = [];
}