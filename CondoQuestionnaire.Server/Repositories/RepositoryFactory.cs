using CondoQuestionnaire.Server.Repository.Class;
using CondoQuestionnaire.Server.Repository.Interface;

namespace CondoQuestionnaire.Server.Repository
{
    public sealed class RepositoryFactory : IRepositoryFactory
    {
        public ILogInRepository LogInRepository { get; }

        public IRegisterRepository RegisterRepository { get; }
        public IUserRepository UserRepository { get; }

        public RepositoryFactory()
        {
            LogInRepository = new LogInRepository();

            RegisterRepository = new RegisterRepository();
            
            UserRepository = new UserRepository();

        }
    }
}