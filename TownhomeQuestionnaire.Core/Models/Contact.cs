namespace TownhomeQuestionnaire.Core.Models;

public sealed class Contact : BaseModel
{
    public string Name { get; set; }
    public Guid? DefaultMethodId { get; set; }
    public ContactMethod DefaultMethod { get; set; }
    public IEnumerable<ContactMethod> ContactMethods { get; set; }
}