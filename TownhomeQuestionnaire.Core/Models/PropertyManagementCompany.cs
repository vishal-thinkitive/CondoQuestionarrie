namespace TownhomeQuestionnaire.Core.Models;

public sealed class PropertyManagementCompany
{
    public string Name { get; set; }
    public string Dba { get; set; }
    public IEnumerable<CondoProperty> Properties { get; set; }
    public IEnumerable<PropertyManagerProfile> PropertyManagers { get; set; }
}