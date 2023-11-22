using System.Linq.Expressions;
using System.Text.RegularExpressions;
using LearningCenter.Persistence.DataContexts;
using LearningCenter.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Persistence.Repositories;

public class GroupRepository : EntityRepositoryBase<Group>, IGroupRepository
{
    public GroupRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Group> Get(Expression<Func<Group, bool>>? predicate = null, bool asNoTracking = false)
    {
        return base.Get(predicate, asNoTracking);
    }

    public ValueTask<Group?> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return base.GetByIdAsync(id, asNoTracking, cancellationToken);
    }

    public ValueTask<IList<Group>> GetByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return base.GetByIdsAsync(ids, asNoTracking, cancellationToken);
    }

    public ValueTask<Group> CreateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.CreateAsync(group, saveChanges, cancellationToken);
    }

    public ValueTask<Group> UpdateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.UpdateAsync(group, saveChanges, cancellationToken);
    }

    public ValueTask<Group?> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.DeleteByIdAsync(id, saveChanges, cancellationToken);
    }

    public ValueTask<Group?> DeleteAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return base.DeleteAsync(group, saveChanges, cancellationToken);
    }


}
