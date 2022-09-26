namespace CondoQuestionnaire.Shared.Models;

public class Address
{
    public string? Name { get; set; }
    public string Line1 { get; set; }
    public string? Line2 { get; set; }
    public string Locality { get; init; }
    public string PostalCode { get; init; }
    public string Region { get; init; }
    public string Country { get; set; } = "US";
    public int? Longitude { get; set; }
    public int? Latitude { get; set; }
}