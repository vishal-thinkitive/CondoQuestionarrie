using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IAddressRepository
{
    public Task<AddressModel> FindByIdAsync(EntityId id, CancellationToken cancellationToken);
    public Task<AddressModel> CreateAsync(AddressModel address, CancellationToken cancellationToken);
    public Task<AddressModel> UpdateAsync(AddressModel address, CancellationToken cancellationToken);
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    public Task DeleteAsync(AddressModel address, CancellationToken cancellationToken, bool softDelete = true);
}