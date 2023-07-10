using CondoQuestionnaire.Server.Services.Class;
using CondoQuestionnaire.Server.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Services
{
    public sealed class ServiceFactory : IServiceFactory
    {
        public ILogInService LogInService { get; }

        public IRegisterService RegisterService { get; }
        public IUserService UserService { get; }

        public ServiceFactory()
        {
            LogInService = new LogInService();

            RegisterService = new RegisterService();
            UserService = new UserService();

        }
    }
}
