using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class PropertyManagerProfileModel: PropertyManagerProfile, IEntity
{
    public EntityId? Id { get; set; }
    public Guid? UserId { get; set; }
    public UserModel? User { get; set; }
    public new ContactModel? Contact { get; set; }
    public new PropertyManagementCompanyModel? CurrentCompany { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}