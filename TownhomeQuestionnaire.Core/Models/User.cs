namespace TownhomeQuestionnaire.Core.Models;

public sealed class User : BaseModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Salt { get; set; }
    public string Password { get; set; }
}