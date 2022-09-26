using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;
    
public sealed class CondoApplicationModel: CondoApplication, IEntity
{
    public Guid? Id { get; set; }
    public new ApplicantProfileModel? Applicant { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}