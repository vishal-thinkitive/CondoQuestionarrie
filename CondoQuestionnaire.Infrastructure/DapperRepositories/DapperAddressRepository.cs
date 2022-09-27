using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Core.Repositories;
using CondoQuestionnaire.Core.Utils.Entity;
using CondoQuestionnaire.Shared.Models;
using SqlKata.Execution;

namespace CondoQuestionnaire.Infrastructure.DapperRepositories;

public class DapperAddressRepository: IAddressRepository
{
    private readonly IDbTransactionFactory _transactionFactory;
    private readonly QueryFactory _queryFactory;

    public DapperAddressRepository(IDbTransactionFactory transactionFactory, QueryFactory queryFactory)
    {
        _transactionFactory = transactionFactory;
        _queryFactory = queryFactory;
    }

    public async Task<AddressModel> FindByIdAsync(EntityId id, CancellationToken cancellationToken)
    {
        var result =  await _queryFactory.Query(EntityToTableNameMapper.GetTableForEntityType(typeof(AddressModel)))
            .Where(nameof(AddressModel.Id), id.ToString())
            .FirstAsync<AddressModel>(await _transactionFactory.GetTransactionAsync(cancellationToken), 
                cancellationToken: cancellationToken);

        return result;
    }

    public Task<AddressModel> CreateAsync(Address address, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<AddressModel> UpdateAsync(Address address, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Address address, CancellationToken cancellationToken, bool softDelete = true)
    {
        throw new NotImplementedException();
    }
}