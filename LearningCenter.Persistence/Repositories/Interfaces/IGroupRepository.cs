using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace LearningCenter.Persistence.Repositories.Interfaces;

public interface IGroupRepository
{
    IQueryable<Group> Get(Expression<Func<Group, bool>>? predicate = default, bool asNoTracking = false);

    ValueTask<Group?> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<IList<Group>> GetByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Group> CreateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Group> UpdateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Group?> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<Group?> DeleteAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default);
}
