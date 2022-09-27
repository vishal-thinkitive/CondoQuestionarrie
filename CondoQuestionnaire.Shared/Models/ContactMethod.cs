namespace CondoQuestionnaire.Shared.Models;

public class ContactMethod
{
    public Guid? ContactId;
    public string Label { get; init; }
    public string Type { get; init; }
    public string ReferenceValue { get; init; }
    
    public Contact? Contact { get; set; }
}