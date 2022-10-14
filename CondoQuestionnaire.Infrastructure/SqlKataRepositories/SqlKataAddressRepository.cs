using CondoQuestionnaire.Core.Models;
using CondoQuestionnaire.Core.Repositories;
using CondoQuestionnaire.Core.Utils.DateTime;
using CondoQuestionnaire.Core.Utils.Entity;
using CondoQuestionnaire.Shared.Models;
using SqlKata.Execution;

namespace CondoQuestionnaire.Infrastructure.SqlKataRepositories;

public class DapperAddressRepository : IAddressRepository
{
    private readonly IDbTransactionFactory _transactionFactory;
    private readonly QueryFactory _queryFactory;
    private readonly string _table;
    private readonly IDateTimeProvider _dateTimeProvider;

    public DapperAddressRepository(IDbTransactionFactory transactionFactory, QueryFactory queryFactory,
        IDateTimeProvider dateTimeProvider)
    {
        _transactionFactory = transactionFactory;
        _queryFactory = queryFactory;
        _dateTimeProvider = dateTimeProvider;
        _table = EntityToTableNameMapper.GetTableForEntityType(typeof(AddressModel));
    }

    public async Task<AddressModel> FindByIdAsync(EntityId id, CancellationToken cancellationToken)
    {
        var result = await _queryFactory.Query(_table)
            .Where(nameof(AddressModel.Id), id.ToString())
            .FirstAsync<AddressModel>(await _transactionFactory.GetTransactionAsync(cancellationToken),
                cancellationToken: cancellationToken);

        return result;
    }

    public async Task<AddressModel> CreateAsync(AddressModel address, CancellationToken cancellationToken)
    {
        var nowTimeStamp = _dateTimeProvider.GetUtcNow();
        address.CreatedAtUtc = nowTimeStamp;
        address.UpdatedAtUtc = nowTimeStamp;
        address.Id = new EntityId();

        await _queryFactory.Query(_table)
            .InsertAsync(address, await _transactionFactory.GetTransactionAsync(cancellationToken),
                cancellationToken: cancellationToken);

        return address;
    }

    public async Task<AddressModel> UpdateAsync(AddressModel address, CancellationToken cancellationToken)
    {
        var nowTimeStamp = _dateTimeProvider.GetUtcNow();
        address.UpdatedAtUtc = nowTimeStamp;

        await _queryFactory.Query(_table)
            .Where(nameof(AddressModel.Id), address.Id?.ToString())
            .UpdateAsync(address, await _transactionFactory.GetTransactionAsync(cancellationToken),
                cancellationToken: cancellationToken);

        return address;
    }

    public async Task DeleteByIdAsync(EntityId id, CancellationToken cancellationToken, bool softDelete = true)
    {
        await _queryFactory.Query(_table)
            .Where(nameof(AddressModel.Id), id.ToString())
            .DeleteAsync(await _transactionFactory.GetTransactionAsync(cancellationToken),
                cancellationToken: cancellationToken);
    }

    public async Task DeleteAsync(AddressModel address, CancellationToken cancellationToken, bool softDelete = true)
    {
        await _queryFactory.Query(_table)
            .Where(nameof(AddressModel.Id), address.Id?.ToString())
            .DeleteAsync(await _transactionFactory.GetTransactionAsync(cancellationToken),
                cancellationToken: cancellationToken);
    }
}