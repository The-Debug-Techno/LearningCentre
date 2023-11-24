using System.Linq.Expressions;
using LearningCenter.Application.Common.Identity.Services;
using LearningCenter.Domain.Entity;
using LearningCenter.Persistence.Repositories.Interfaces;

namespace LearningCenter.Infrastructure.Common.Identity.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;

    public GroupService(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public IQueryable<Group> Get(Expression<Func<Group, bool>>? predicate = null, bool asNoTracking = false)
    {
        return _groupRepository.Get(predicate, asNoTracking);
    }

    public ValueTask<Group?> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return _groupRepository.GetByIdAsync(id, asNoTracking, cancellationToken);
    }

    public ValueTask<IList<Group>> GetByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return _groupRepository.GetByIdsAsync(ids, asNoTracking, cancellationToken);
    }
    public ValueTask<Group> CreateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _groupRepository.CreateAsync(group, saveChanges, cancellationToken);
    }

    public ValueTask<Group> UpdateAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _groupRepository.UpdateAsync(group,saveChanges, cancellationToken);
    }

    public ValueTask<Group?> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _groupRepository.DeleteByIdAsync(id, saveChanges, cancellationToken);
    }

    public ValueTask<Group?> DeleteAsync(Group group, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _groupRepository.DeleteAsync(group, saveChanges, cancellationToken);
    }
}
