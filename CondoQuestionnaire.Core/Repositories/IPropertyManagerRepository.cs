using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IPropertyManagerRepository
{
    public Task<PropertyManagerProfileModel> FindById(EntityId id, IncludeDescription<PropertyManagerProfile> description);
    public Task<PropertyManagerProfileModel> FindByEmailOrPhone(string emailOrPhone, IncludeDescription<PropertyManagerProfile> description);
    public Task<PropertyManagerProfileModel> FindByApplication(CondoApplication application, IncludeDescription<PropertyManagerProfile> description);
    public Task<IEnumerable<PropertyManagerProfileModel>> FindManagersByProperty(CondoProperty property, IncludeDescription<PropertyManagerProfile> description);
    public Task<PropertyManagerProfileModel> Create(PropertyManagerProfile property);
    public Task<PropertyManagerProfileModel> Update(PropertyManagerProfile property);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(PropertyManagerProfile property, bool softDelete = true);
}