using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class ContactMethodModel: ContactMethod, IEntity
{
    public Guid? Id { get; set; }
    public new ContactModel? Contact { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}