namespace CondoQuestionnaire.Shared.Models;

public class CondoQuestionnaireApplication
{
    public string CurrentQuestionCode { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string FannieMaeStatus { get; set; } = string.Empty;
    public DateTime? FannieMaeLastUpdatedAtUtc { get; set; }
    public DateTime? CompletedAt { get; set; }
    public EntityId? ProjectId { get; set; }
    public IEnumerable<CondoQuestionnaireAnswer> Answers = Enumerable.Empty<CondoQuestionnaireAnswer>();
}