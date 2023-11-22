using System.Linq.Expressions;
using LearningCenter.Domain.Entity;

namespace LearningCenter.Application.Common.Identity.Services;

public interface IGroupService
{
    IQueryable<Group> Get(Expression<Func<Group, bool>>? predicate = default, bool asNoTracking = false);

    ValueTask<Group?> GetByIdAsync(Guid id, bool  asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<IList<Group>> GetByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Group> CreateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Group> UpdateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken= default);

    ValueTask<Group?> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Group?> DeleteAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default);
}
