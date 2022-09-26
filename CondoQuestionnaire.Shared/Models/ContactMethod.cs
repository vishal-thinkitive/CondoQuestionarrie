namespace CondoQuestionnaire.Shared.Models;

public class ContactMethod
{
    public Guid? ContactId;
    public string? Type { get; set; }
    public string? ReferenceValue { get; set; }
    public Contact? Contact { get; set; }
}