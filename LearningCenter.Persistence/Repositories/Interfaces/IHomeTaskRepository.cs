using LearningCenter.Domain.Entity;
using System.Linq.Expressions;

namespace LearningCenter.Persistence.Repositories.Interfaces;

public interface IHomeTaskRepository
{
    IQueryable<HomeTask> Get(Expression<Func<HomeTask, bool>>? predicate = default, bool asNoTracking = false);

    ValueTask<HomeTask?> GetHomeTaskByIdAsync(Guid hometaskId, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<IList<HomeTask>> GetHomeTaskByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<HomeTask> CreateAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<HomeTask> UpdateAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<HomeTask?> DeleteHomeTaskByIdAsync(Guid hometaskId, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<HomeTask?> DeleteAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default);
}
