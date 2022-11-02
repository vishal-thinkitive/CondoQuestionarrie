namespace CondoQuestionnaire.Shared.Models;

public class CondoApplication
{
    public string Status { get; init; }
    public DateTime? CompletedAtUtc { get; set; }
    public Guid? ApplicantId { get; set; }
    public ApplicantProfile? Applicant { get; set; }
    public Contact? ApplicantContact { get; set; }
}