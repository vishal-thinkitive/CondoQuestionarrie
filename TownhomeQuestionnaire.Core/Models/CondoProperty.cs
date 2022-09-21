namespace TownhomeQuestionnaire.Core.Models;

public sealed class CondoProperty : BaseModel
{
    public string Name { get; set; }
    public string Type { get; set; }
    public Address Address { get; set; }
    public string Source { get; set; }
    public string SourceRef { get; set; }
    public Guid? CompanyId { get; set; }
    public PropertyManagementCompany Company { get; set; }
}