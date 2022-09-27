using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IContactRepository
{
    public Task<ContactModel> FindByIdAsync(EntityId id, IncludeDescription<Contact> description, CancellationToken cancellationToken);
    public Task<ContactModel> CreateAsync(Contact address, CancellationToken cancellationToken);
    public Task<ContactModel> AddContactMethodAsync(Contact address, ContactMethod method, CancellationToken cancellationToken);
    public Task<ContactModel> UpdateAsync(Contact address, CancellationToken cancellationToken);
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    public Task DeleteAsync(Contact contact, CancellationToken cancellationToken, bool softDelete = true);
}