using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface ICondoPropertyRepository
{
    public Task<CondoPropertyModel> FindById(EntityId id, IncludeDescription<CondoPropertyModel> description);
    public Task<CondoPropertyModel> Create(CondoProperty property);
    public Task<CondoPropertyModel> Update(CondoProperty property);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(CondoProperty property, bool softDelete = true);
}