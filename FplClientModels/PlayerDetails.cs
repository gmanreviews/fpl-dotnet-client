namespace FplClientModels;

[UsedImplicitly]
public class PlayerDetails : PlayerStatsDetails
{
    [JsonPropertyName("birth_date")]
    public string? BirthDate { get; set; }
    [JsonPropertyName("can_select")]
    public bool CanSelect { get; set; }
    [JsonPropertyName("can_transact")]
    public bool CanTransact { get; set; }
    [JsonPropertyName("chance_of_playing_next_round")]
    public int? ChanceOfPlayingNextRound { get; set; }
    [JsonPropertyName("chance_of_playing_this_round")]
    public int? ChanceOfPlayingThisRound { get; set; }
    [JsonPropertyName("clean_sheets_per_90")]
    public float? CleanSheetsPer90 { get; set; }
    [JsonPropertyName("code")]
    public int Code { get; set; }
    [JsonPropertyName("corners_and_indirect_freekicks_order")]
    public int? CornersAndIndirectFreeKicksOrder { get; set; }
    [JsonPropertyName("corners_and_indirect_freekicks_text")]
    public string? CornersAndIndirectFreeKicksText { get; set; }
    [JsonPropertyName("cost_change_event")]
    public int CostChangeEvent { get; set; }
    [JsonPropertyName("cost_change_event_fall")]
    public int CostChangeEventFall { get; set; }
    [JsonPropertyName("cost_change_start")]
    public int CostChangeStart { get; set; }
    [JsonPropertyName("cost_change_start_fall")]
    public int CostChangeStartFall { get; set; }
    [JsonPropertyName("creativity_rank")]
    public int CreativityRank { get; set; }
    [JsonPropertyName("creativity_rank_type")]
    public int CreativityRankType { get; set; }
    [JsonPropertyName("direct_freekicks_order")]
    public int? DirectFreeKickOrder { get; set; }
    [JsonPropertyName("direct_freekicks_text")]
    public string? DirectFreeKickText { get; set; }
    [JsonPropertyName("dreamteam_count")]
    public int DreamTeamCount { get; set; }
    [JsonPropertyName("element_type")]
    public int ElementType { get; set; }
    [JsonPropertyName("ep_next")]
    public string? EpNext { get; set; }
    [JsonPropertyName("ep_this")]
    public string? EpThis { get; set; }
    [JsonPropertyName("event_points")]
    public int EventPoints { get; set; }
    [JsonPropertyName("expected_assists_per_90")]
    public float? ExpectedAssistsPer90 { get; set; }
    [JsonPropertyName("expected_goals_conceded_per_90")]
    public float? ExpectedGoalsConcededPer90 { get; set; }
    [JsonPropertyName("expected_goals_per_90")]
    public float? ExpectedGoalsPer90 { get; set; }
    [JsonPropertyName("expected_goal_involvements_per_90")]
    public float? ExpectedGoalsInvolvementPer90 { get; set; }
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }
    [JsonPropertyName("form")]
    public string? Form { get; set; }
    [JsonPropertyName("form_rank")]
    public int FormRank { get; set; }
    [JsonPropertyName("form_rank_type")]
    public int FormRankType { get; set; }
    [JsonPropertyName("goals_conceded_per_90")]
    public float? GoalsConcededPer90 { get; set; }
    [JsonPropertyName("has_temporary_code")]
    public bool HasTemporaryCode { get; set; }
    [JsonPropertyName("ict_index_rank")]
    public int IctRank { get; set; }
    [JsonPropertyName("ict_index_rank_type")]
    public int IctRankType { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("influence_rank")]
    public int InfluenceRank { get; set; }
    [JsonPropertyName("influence_rank_type")]
    public int InfluenceRankType { get; set; }
    [JsonPropertyName("in_dreamteam")]
    public bool InDreamTeam { get; set; }
    [JsonPropertyName("news")]
    public string? News { get; set; }
    [JsonPropertyName("news_added")]
    public string? NewsAdded { get; set; }
    [JsonPropertyName("now_cost")]
    public int NowCost { get; set; }
    [JsonPropertyName("now_cost_rank")]
    public int NowCostRank { get; set; }
    [JsonPropertyName("now_cost_rank_type")]
    public int NowCostRankType { get; set; }
    [JsonPropertyName("opta_code")]
    public string? OptaCode { get; set; }
    [JsonPropertyName("penalties_order")]
    public int? PenaltiesOrder { get; set; }
    [JsonPropertyName("penalties_text")]
    public string? Penalties { get; set; }
    [JsonPropertyName("photo")]
    public string? Photo { get; set; }
    [JsonPropertyName("points_per_game")]
    public string? PointsPerGame { get; set; }
    [JsonPropertyName("points_per_game_rank")]
    public int PointsPerGameRank { get; set; }
    [JsonPropertyName("points_per_game_rank_type")]
    public int PointsPerGameRankType { get; set; }
    [JsonPropertyName("region")]
    public int? Region { get; set; }
    [JsonPropertyName("removed")]
    public bool Removed { get; set; }
    [JsonPropertyName("saves_per_90")]
    public float SavesPer90 { get; set; }
    [JsonPropertyName("second_name")]
    public string? SecondName { get; set; }
    [JsonPropertyName("selected_by_percent")]
    public string? SelectedByPercent { get; set; }
    [JsonPropertyName("selected_rank")]
    public int SelectedRank { get; set; }
    [JsonPropertyName("selected_rank_type")]
    public int SelectedRankType { get; set; }
    [JsonPropertyName("special")]
    public bool Special { get; set; }
    [JsonPropertyName("squad_number")]
    public int? SquadNo { get; set; }
    [JsonPropertyName("starts_per_90")]
    public float StartsPer90 { get; set; }
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    [JsonPropertyName("team")]
    public int? Team { get; set; }
    [JsonPropertyName("team_code")]
    public int? TeamCode { get; set; }
    [JsonPropertyName("team_join_date")]
    public string? TeamJoinData { get; set; }
    [JsonPropertyName("threat_rank")]
    public int ThreatRank { get; set; }
    [JsonPropertyName("threat_rank_type")]
    public int ThreatRankType { get; set; }
    [JsonPropertyName("transfers_in")]
    public int TransfersIn { get; set; }
    [JsonPropertyName("transfers_in_event")]
    public int TransfersInEvent { get; set; }
    [JsonPropertyName("transfers_out")]
    public int TransfersOut { get; set; }
    [JsonPropertyName("transfers_out_event")]
    public int TransfersOutEvent { get; set; }
    [JsonPropertyName("value_form")]
    public string? ValueForm { get; set; }
    [JsonPropertyName("value_season")]
    public string? ValueSeason { get; set; }
    [JsonPropertyName("web_name")]
    public string? WebName { get; set; }
}