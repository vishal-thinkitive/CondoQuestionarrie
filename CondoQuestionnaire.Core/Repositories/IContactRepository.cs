using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IContactRepository
{
    public Task<ContactModel> FindByIdAsync(EntityId id, IncludeDescription<Contact> description,
        CancellationToken cancellationToken);

    public Task<ContactModel> CreateAsync(ContactModel contact, CancellationToken cancellationToken);

    public Task<ContactModel> AddContactMethodAsync(ContactModel contact, ContactMethodModel method,
        CancellationToken cancellationToken);

    public Task<ContactModel> UpdateAsync(ContactModel address, CancellationToken cancellationToken);
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    public Task DeleteAsync(ContactModel contact, CancellationToken cancellationToken, bool softDelete = true);
}