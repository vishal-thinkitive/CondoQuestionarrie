using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface ICondoPropertyRepository
{
    public Task<CondoPropertyModel> FindByIdAsync(EntityId id, IncludeDescription<CondoPropertyModel> description, CancellationToken cancellationToken);
    public Task<CondoPropertyModel> CreateAsync(CondoProperty property, CancellationToken cancellationToken);
    public Task<CondoPropertyModel> UpdateAsync(CondoProperty property, CancellationToken cancellationToken);
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    public Task DeleteAsync(CondoProperty property, CancellationToken cancellationToken, bool softDelete = true);
}