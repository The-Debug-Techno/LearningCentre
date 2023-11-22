using System.Linq.Expressions;
using LearningCenter.Domain.Entity;
using LearningCenter.Persistence.DataContexts;
using LearningCenter.Persistence.Repositories.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Persistence.Repositories;

public class HomeTaskRepository : EntityRepositoryBase<HomeTask>, IHomeTaskRepository
{
    public HomeTaskRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<HomeTask> Get(Expression<Func<HomeTask, bool>>? predicate = null, bool asNoTracking = false)
    {
        return base.Get(predicate, asNoTracking);
    }

    public ValueTask<HomeTask?> GetHomeTaskByIdAsync(Guid hometaskId, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return base.GetByIdAsync(hometaskId, asNoTracking, cancellationToken);
    }

    public ValueTask<IList<HomeTask>> GetHomeTaskByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return base.GetByIdsAsync(ids, asNoTracking, cancellationToken);
    }
    public ValueTask<HomeTask> CreateAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.CreateAsync(homeTask, saveChanges, cancellationToken);
    }

    public ValueTask<HomeTask> UpdateAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.UpdateAsync(homeTask, saveChanges, cancellationToken);
    }

    public ValueTask<HomeTask?> DeleteHomeTaskByIdAsync(Guid hometaskId, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.DeleteByIdAsync(hometaskId, saveChanges, cancellationToken);
    }
    public ValueTask<HomeTask?> DeleteAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.DeleteAsync(homeTask, saveChanges, cancellationToken);
    }
}
