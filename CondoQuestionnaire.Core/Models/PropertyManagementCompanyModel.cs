using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class PropertyManagementCompanyModel: PropertyManagementCompany, IEntity
{
    public Guid? Id { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
    public new IEnumerable<CondoPropertyModel> Properties { get; set; } = Enumerable.Empty<CondoPropertyModel>();
}