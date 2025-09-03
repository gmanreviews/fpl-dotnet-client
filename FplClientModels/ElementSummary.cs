using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class ElementSummary
{
    [JsonPropertyName("fixtures")] 
    public Fixture[] Fixtures { get; set; } = [];
    [JsonPropertyName("history")] 
    public ElementHistory[] History { get; set; } = [];
    
}