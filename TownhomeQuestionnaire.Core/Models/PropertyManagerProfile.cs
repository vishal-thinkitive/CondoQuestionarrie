namespace TownhomeQuestionnaire.Core.Models;

public sealed class PropertyManagerProfile
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid? ContactId { get; set; }
    public Contact Contact { get; set; }
    public Guid? CurrentCompanyId { get; set; }
    public PropertyManagementCompany CurrentCompany { get; set; }
}