using CondoQuestionnaire.Core.Includes;
using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Shared.Models;

namespace CondoQuestionnaire.Core.Repositories;

public interface ICondoApplicationRepository
{
    public Task<CondoApplicationModel> FindByIdAsync(EntityId id, IncludeDescription<CondoApplication> description, CancellationToken cancellationToken);
    
    public Task<ApplicantProfileModel> FindByEmailOrPhoneAsync(string emailOrPhone, IncludeDescription<CondoApplication> description, CancellationToken cancellationToken);
    
    public Task<ApplicantProfileModel> FindByApplicationAsync(CondoApplication application, IncludeDescription<CondoApplication> description, CancellationToken cancellationToken);
    
    public Task<IEnumerable<ApplicantProfileModel>> FindManyByPropertyAsync(ApplicantProfile applicant, IncludeDescription<CondoApplication> description, CancellationToken cancellationToken);
    
    public Task<IEnumerable<ApplicantProfileModel>> FindManyByPropertyManagerAsync(PropertyManagerProfile manager, IncludeDescription<CondoApplication> description, CancellationToken cancellationToken);
    
    public Task<ApplicantProfileModel> CreateAsync(CondoApplication application, CancellationToken cancellationToken);
    
    public Task<ApplicantProfileModel> UpdateAsync(CondoApplication application, CancellationToken cancellationToken);
    
    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true);
    
    public Task DeleteAsync(CondoApplication application, CancellationToken cancellationToken, bool softDelete = true);
}