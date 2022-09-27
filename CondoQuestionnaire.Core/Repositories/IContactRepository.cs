using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IContactRepository
{
    public Task<ContactModel> FindById(EntityId id, IncludeDescription<Contact> description);
    public Task<ContactModel> Create(Contact address);
    public Task<ContactModel> AddContactMethod(Contact address, ContactMethod method);
    public Task<ContactModel> Update(Contact address);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(Contact contact, bool softDelete = true);
}