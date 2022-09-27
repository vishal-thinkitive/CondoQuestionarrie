using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IUserRepository
{
    public Task<UserModel> FindByIdAsync(EntityId id, IncludeDescription<UserModel> description, CancellationToken cancellationToken);
    public Task<UserModel> FindByEmailOrPhoneAsync(string emailOrPhone, IncludeDescription<UserModel> description, CancellationToken cancellationToken);
    public Task<UserModel> CreateAsync(UserModel user, CancellationToken cancellationToken);
    public Task<UserModel> UpdateAsync(UserModel user, CancellationToken cancellationToken);
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    public Task DeleteAsync(UserModel user, CancellationToken cancellationToken, bool softDelete = true);
}