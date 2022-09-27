using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class AddressModel : Address, IEntity
{
    public EntityId? Id { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}