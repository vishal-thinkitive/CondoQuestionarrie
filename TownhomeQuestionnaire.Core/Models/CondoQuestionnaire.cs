namespace TownhomeQuestionnaire.Core.Models;

public sealed class CondoQuestionnaire : BaseModel
{
    public string Status { get; set; }
    public string CurrentQuestionCode { get; set; }
    public DateTime? CompletedAtUtc { get; set; }
}