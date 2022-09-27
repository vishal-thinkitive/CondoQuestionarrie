using System.Data;

namespace CondoQuestionnaire.Core.Repositories;

public interface IDbTransactionFactory
{
    Task<IDbTransaction> GetTransactionAsync(CancellationToken cancellationToken);
}