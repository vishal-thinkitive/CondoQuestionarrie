using CondoQuestionnaire.Server.Repository;

namespace CondoQuestionnaire.Server.Services.Interface
{
    public interface IBaseService
    {
        IRepositoryFactory RepositoryFactory { get; }

        string Encrypt(string plainText);
    }
}
