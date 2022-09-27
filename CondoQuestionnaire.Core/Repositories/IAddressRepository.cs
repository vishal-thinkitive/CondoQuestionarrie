using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IAddressRepository
{
    public Task<Address> FindById(EntityId id);
    public Task<AddressModel> Create(Address address);
    public Task<AddressModel> Update(Address address);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task<AddressModel> Delete(AddressModel address, bool softDelete = true);
}