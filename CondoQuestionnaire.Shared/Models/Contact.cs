namespace CondoQuestionnaire.Shared.Models;

public class Contact
{
    public string? Name { get; set; }
    public Guid? DefaultMethodId { get; set; }
    public ContactMethod? DefaultMethod { get; set; }
    public IEnumerable<ContactMethod> ContactMethods { get; set; } = Enumerable.Empty<ContactMethod>();
}