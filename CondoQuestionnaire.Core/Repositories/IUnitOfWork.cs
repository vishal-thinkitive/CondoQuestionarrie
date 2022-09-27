using System.Data;

namespace CondoQuestionnaire.Core.Repositories;

public interface IUnitOfWork: IDisposable
{
    Task BeginTransactionAsync(CancellationToken cancellationToken);
    Task CommitAsync(CancellationToken cancellationToken);
    Task RollbackAsync(CancellationToken cancellationToken);
}