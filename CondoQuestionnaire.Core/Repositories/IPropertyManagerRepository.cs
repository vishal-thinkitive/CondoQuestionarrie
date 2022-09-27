using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IPropertyManagerRepository
{
    public Task<PropertyManagerProfileModel> FindByIdAsync(EntityId id,
        IncludeDescription<PropertyManagerProfile> description, CancellationToken cancellationToken);

    public Task<PropertyManagerProfileModel> FindByEmailOrPhoneAsync(string emailOrPhone,
        IncludeDescription<PropertyManagerProfile> description, CancellationToken cancellationToken);

    public Task<PropertyManagerProfileModel> FindByApplicationAsync(CondoApplication application,
        IncludeDescription<PropertyManagerProfile> description, CancellationToken cancellationToken);

    public Task<IEnumerable<PropertyManagerProfileModel>> FindManyByPropertyAsync(CondoProperty property,
        IncludeDescription<PropertyManagerProfile> description, CancellationToken cancellationToken);

    public Task<PropertyManagerProfileModel> CreateAsync(PropertyManagerProfileModel property,
        CancellationToken cancellationToken);

    public Task<PropertyManagerProfileModel> UpdateAsync(PropertyManagerProfileModel property,
        CancellationToken cancellationToken);

    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);

    public Task DeleteAsync(PropertyManagerProfileModel property, CancellationToken cancellationToken,
        bool softDelete = true);
}