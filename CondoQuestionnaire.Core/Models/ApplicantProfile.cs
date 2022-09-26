using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Models;

public sealed class ApplicantProfileModel : ApplicantProfile, IEntity
{
    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public UserModel? User { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
}