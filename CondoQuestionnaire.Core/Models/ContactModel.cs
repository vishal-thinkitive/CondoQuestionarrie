using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class ContactModel : Contact, IEntity
{
    public Guid? Id { get; set; }
    public new ContactMethodModel? DefaultMethod { get; set; }
    public new IEnumerable<ContactMethodModel> ContactMethods { get; set; } = Enumerable.Empty<ContactMethodModel>();
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}