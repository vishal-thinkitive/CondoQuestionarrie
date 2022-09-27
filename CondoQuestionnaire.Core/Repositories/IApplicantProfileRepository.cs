using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IApplicantProfileRepository
{
    public Task<ApplicantProfileModel> FindByIdAsync(EntityId id, IncludeDescription<ApplicantProfile> description,
        CancellationToken cancellationToken);

    public Task<ApplicantProfileModel> FindByEmailOrPhoneAsync(string emailOrPhone,
        IncludeDescription<ApplicantProfileModel> description, CancellationToken cancellationToken);

    public Task<ApplicantProfileModel> FindByApplicationAsync(CondoApplication application,
        IncludeDescription<ApplicantProfileModel> description, CancellationToken cancellationToken);

    public Task<IEnumerable<ApplicantProfileModel>> FindManyByPropertyAsync(CondoProperty property,
        IncludeDescription<PropertyManagerProfile> description, CancellationToken cancellationToken);

    public Task<ApplicantProfileModel> CreateAsync(ApplicantProfileModel property, CancellationToken cancellationToken);

    public Task<ApplicantProfileModel> UpdateAsync(ApplicantProfileModel property, CancellationToken cancellationToken);

    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);

    public Task DeleteAsync(ApplicantProfileModel property, CancellationToken cancellationToken, bool softDelete = true);
}