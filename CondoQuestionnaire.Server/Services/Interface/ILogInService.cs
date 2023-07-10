using CondoQuestionnaire.Server.DataModel;

namespace CondoQuestionnaire.Server.Services.Interface
{
    public interface ILogInService
    {
        Task<bool> LogInUser(LogIn logInUser);
    }
}
