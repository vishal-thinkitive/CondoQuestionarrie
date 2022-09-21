namespace TownhomeQuestionnaire.Core.Models;

public abstract class BaseModel
{
    public Guid? Id { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}