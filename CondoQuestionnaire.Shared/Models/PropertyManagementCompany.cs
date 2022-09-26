namespace CondoQuestionnaire.Shared.Models;

public class PropertyManagementCompany
{
    public string? Name { get; set; }
    public string? Dba { get; set; }
    public IEnumerable<CondoProperty> Properties { get; set; } = Enumerable.Empty<CondoProperty>();

    public IEnumerable<PropertyManagerProfile>? PropertyManagers { get; set; } =
        Enumerable.Empty<PropertyManagerProfile>();
}