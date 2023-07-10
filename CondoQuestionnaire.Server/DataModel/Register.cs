using System.Text.Json.Serialization;

namespace CondoQuestionnaire.Server.DataModel
{
    public class Register
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool PaymentDone { get; set; } = false;
        [JsonIgnore]
        public bool IsRegistered { get; set; } = false;
    }
}
