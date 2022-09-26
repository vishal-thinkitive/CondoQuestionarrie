namespace CondoQuestionnaire.Shared.Models;

public class CondoApplication
{
    public string Status { get; init; }
    public string CurrentQuestionCode { get; init; }
    public DateTime? CompletedAtUtc { get; set; }
    public Guid? ApplicantId { get; set; }
    public ApplicantProfile? Applicant { get; set; }

    public string?  LenderName { get; set; }
    public string? LenderPhoneNumber { get; set; }
    public string? ContactName { get; set; }
    public string? LenderFaxNumber { get; set; }
}