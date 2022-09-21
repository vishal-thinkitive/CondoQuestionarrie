namespace TownhomeQuestionnaire.Core.Models;

public sealed class Address : BaseModel
{
    public string Name { get; set; }
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string Locality { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public int Longitude { get; set; }
    public int Latitude { get; set; }
}