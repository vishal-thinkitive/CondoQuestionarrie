namespace CondoQuestionnaire.Shared.Models;

public class ApplicantProfile
{
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Guid? ContactId { get; set; }
    public Contact? Contact { get; set; }
}