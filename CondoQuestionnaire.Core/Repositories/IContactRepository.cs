using CondoQuestionnaire.Core.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IContactRepository
{
    public Task<ContactModel> FindById(EntityId id);
    public Task<ContactModel> Create(ContactModel address);
    public Task<ContactModel> Update(ContactModel address);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task<ContactModel> Delete(ContactModel contact, bool softDelete = true);
}