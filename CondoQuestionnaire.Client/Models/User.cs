namespace CondoQuestionnaire.Client.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public bool PaymentDone { get; set; } = false;

    }

    public class LogInRes
    {
        public string message { get; set; }
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
    }
    public class UserRes
    {
        public string message { get; set; }
        public UserResData data { get; set; }
        public class UserResData
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public bool PaymentDone { get; set; } = false;
        }
    }
    public class LogIn
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class Register
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
