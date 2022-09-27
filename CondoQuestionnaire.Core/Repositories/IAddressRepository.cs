using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IAddressRepository
{
    public Task<AddressModel> FindByIdAsync(EntityId id, CancellationToken cancellationToken);
    public Task<AddressModel> CreateAsync(Address address, CancellationToken cancellationToken);
    public Task<AddressModel> UpdateAsync(Address address, CancellationToken cancellationToken);
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    public Task DeleteAsync(Address address, CancellationToken cancellationToken, bool softDelete = true);
}