using CondoQuestionnaire.Server.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Services
{
    public interface IServiceFactory
    {
        ILogInService LogInService { get; }
        IRegisterService RegisterService { get; }
        IUserService UserService { get; }
    }
}
