using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IAddressRepository
{
    public Task<AddressModel> FindById(EntityId id);
    public Task<AddressModel> Create(Address address);
    public Task<AddressModel> Update(Address address);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(Address address, bool softDelete = true);
}