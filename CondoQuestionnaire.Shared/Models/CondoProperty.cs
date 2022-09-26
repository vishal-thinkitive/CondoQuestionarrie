namespace CondoQuestionnaire.Shared.Models;

public class CondoProperty
{
    public string Name { get; init; }
    public string Type { get; init; }
    public string Status { get; init; }
    public Guid? AddressId { get; init; }
    public Address? Address { get; set; }
    public string Source { get; init; }
    public string? SourceRef { get; init; }
    public Guid CompanyId { get; init; }
    public PropertyManagementCompany? Company { get; set; }
}