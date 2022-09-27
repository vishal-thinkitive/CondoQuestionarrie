using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface IApplicantProfileRepository
{
    public Task<ApplicantProfileModel> FindById(EntityId id, IncludeDescription<ApplicantProfile> description);
    public Task<ApplicantProfileModel> FindByEmailOrPhone(string emailOrPhone, IncludeDescription<ApplicantProfile> description);
    public Task<ApplicantProfileModel> FindByApplication(CondoApplication application, IncludeDescription<ApplicantProfile> description);
    public Task<IEnumerable<ApplicantProfileModel>> FindManyByProperty(CondoProperty property, IncludeDescription<PropertyManagerProfile> description);
    public Task<ApplicantProfileModel> Create(ApplicantProfile property);
    public Task<ApplicantProfileModel> Update(ApplicantProfile property);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(ApplicantProfile property, bool softDelete = true);
}