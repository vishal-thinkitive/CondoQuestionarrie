namespace TownhomeQuestionnaire.Core.Models;

public sealed class ContactMethod : BaseModel
{
    public string Type { get; set; }
    public string ReferenceValue { get; set; }
    public Contact Contact { get; set; }
}