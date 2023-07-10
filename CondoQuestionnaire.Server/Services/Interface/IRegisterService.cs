using CondoQuestionnaire.Server.DataModel;

namespace CondoQuestionnaire.Server.Services.Interface
{
    public interface IRegisterService
    {
        Task<bool> RegisterUser(Register registerUser);
        Task SendMail(Register user);
        Task<bool> VerifyEmail(string email);
    }
}
