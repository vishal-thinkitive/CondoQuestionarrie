using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface ICondoApplicationRepository
{
    public Task<CondoApplicationModel> FindById(EntityId id, IncludeDescription<CondoApplication> description);
    public Task<ApplicantProfileModel> FindByEmailOrPhone(string emailOrPhone, IncludeDescription<CondoApplication> description);
    public Task<ApplicantProfileModel> FindByApplication(CondoApplication application, IncludeDescription<CondoApplication> description);
    public Task<IEnumerable<ApplicantProfileModel>> FindManyByProperty(ApplicantProfile applicant, IncludeDescription<CondoApplication> description);
    public Task<IEnumerable<ApplicantProfileModel>> FindManyByPropertyManager(PropertyManagerProfile manager, IncludeDescription<CondoApplication> description);
    public Task<ApplicantProfileModel> Create(CondoApplication application);
    public Task<ApplicantProfileModel> Update(CondoApplication application);
    public Task DeleteById(EntityId id, bool softDelete = true);
    public Task Delete(CondoApplication application, bool softDelete = true);
}