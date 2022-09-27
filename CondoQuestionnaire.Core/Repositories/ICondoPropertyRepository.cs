using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface ICondoPropertyRepository
{
    public Task<CondoPropertyModel> FindById(EntityId id, IncludeDescription<CondoPropertyModel> description);
    public Task<CondoPropertyModel> Create(ContactModel address);
    public Task<CondoPropertyModel> Update(ContactModel address);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task<CondoPropertyModel> Delete(ContactModel contact, bool softDelete = true);
}