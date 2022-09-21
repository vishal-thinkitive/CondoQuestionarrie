namespace TownhomeQuestionnaire.Core.Models;

public sealed class ApplicantProfile : BaseModel
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid? ContactId { get; set; }
    public Contact Contact { get; set; }
}