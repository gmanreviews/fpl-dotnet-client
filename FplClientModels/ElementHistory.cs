using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace FplClientModels;

[UsedImplicitly]
public class ElementHistory
{
    [JsonPropertyName("assists")]
    public required int Assists { get; set; }
    [JsonPropertyName("bonus")]
    public int Bonus { get; set; }
    [JsonPropertyName("bps")]
    public int BonusPointSystem { get; set; }
    [JsonPropertyName("clean_sheets")]
    public int CleanSheets { get; set; }
    [JsonPropertyName("clearances_blocks_interceptions")]
    public int ClearancesBlocksInterceptions { get; set; }
    [JsonPropertyName("creativity")]
    public string? Creativity { get; set; }
    [JsonPropertyName("defensive_contribution")]
    public int DefensiveContribution { get; set; }
    [JsonPropertyName("element")]
    public int Element { get; set; }
    [JsonPropertyName("expected_assists")]
    public string? ExpectedAssists { get; set; }
    [JsonPropertyName("expected_goals")]
    public string? ExpectedGoals { get; set; }
    [JsonPropertyName("expected_goals_conceded")]
    public string? ExpectedGoalsConceded { get; set; }
    [JsonPropertyName("expected_goal_involvements")]
    public string? ExpectedGoalsInvolvements { get; set; }
    [JsonPropertyName("fixture")]
    public int Fixture { get; set; }
    [JsonPropertyName("goals_conceded")]
    public int GoalsConceded { get; set; }
    [JsonPropertyName("goals_scored")]
    public int GoalsScored { get; set; }
    [JsonPropertyName("ict_index")]
    public string? IctIndex { get; set; }
    [JsonPropertyName("influence")]
    public string? Influence { get; set; }
    [JsonPropertyName("kickoff_time")]
    public string? KickoffTime { get; set; }
    [JsonPropertyName("minutes")]
    public int Minutes { get; set; }
    [JsonPropertyName("modified")]
    public bool? Modified { get; set; }
    [JsonPropertyName("opponent_team")]
    public int OpponentTeam { get; set; }
    [JsonPropertyName("own_goals")]
    public int OwnGoals { get; set; }
    [JsonPropertyName("penalties_missed")]
    public int PenaltiesMissed { get; set; }
    [JsonPropertyName("penalties_saved")]
    public int PenaltiesSaved { get; set; }
    [JsonPropertyName("recoveries")]
    public int Recoveries { get; set; }
    [JsonPropertyName("red_cards")]
    public int RedCards { get; set; }
    [JsonPropertyName("round")]
    public int Round { get; set; }
    [JsonPropertyName("saves")]
    public int Saves { get; set; }
    [JsonPropertyName("selected")]
    public int Selected { get; set; }
    [JsonPropertyName("starts")]
    public int Starts { get; set; }
    [JsonPropertyName("tackles")]
    public int Tackles { get; set; }
    [JsonPropertyName("team_a_score")]
    public int AwayScore { get; set; }
    [JsonPropertyName("team_h_score")]
    public int HomeScore { get; set; }
    [JsonPropertyName("threat")]
    public string? Threat { get; set; }
    [JsonPropertyName("total_points")]
    public int TotalPoints { get; set; }
    [JsonPropertyName("transfers_balance")]
    public int TransfersBalance { get; set; }
    [JsonPropertyName("transfers_in")]
    public int TransfersIn { get; set; }
    [JsonPropertyName("transfers_out")]
    public int TransfersOut { get; set; }
    [JsonPropertyName("value")]
    public int Value { get; set; }
    [JsonPropertyName("was_home")]
    public bool? WasHome { get; set; }
    [JsonPropertyName("yellow_cards")]
    public int YellowCards { get; set; }
}