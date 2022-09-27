using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class CondoPropertyModel : CondoProperty, IEntity
{
    public EntityId? Id { get; set; }
    public new AddressModel Address { get; init; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}