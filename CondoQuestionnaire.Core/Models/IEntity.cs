namespace CondoQuestionnaire.Core.Models;

public interface IEntity
{
    public EntityId? Id { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}