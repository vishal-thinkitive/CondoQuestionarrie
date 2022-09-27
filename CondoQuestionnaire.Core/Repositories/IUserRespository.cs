using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IUserRepository
{
    public Task<UserModel> FindById(EntityId id, IncludeDescription<UserModel> description);
    public Task<UserModel> FindByEmailOrPhone(string emailOrPhone, IncludeDescription<UserModel> description);
    public Task<UserModel> Create(UserModel user);
    public Task<UserModel> Update(UserModel user);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(UserModel user, bool softDelete = true);
}