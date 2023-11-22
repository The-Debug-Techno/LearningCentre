using System.Linq.Expressions;
using LearningCenter.Application.Common.Identity.Services;
using LearningCenter.Domain.Entity;
using LearningCenter.Persistence.Repositories.Interfaces;

namespace LearningCenter.Infrastructure.Common.Identity.Services;

public class HomeTaskService : IHomeTaskService
{
    private readonly IHomeTaskRepository _taskRepository;

    public HomeTaskService(IHomeTaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public IQueryable<HomeTask> Get(Expression<Func<HomeTask, bool>>? predicate = null, bool asNoTracking = false)
    {
        return _taskRepository.Get(predicate, asNoTracking);
    }

    public ValueTask<HomeTask?> GetHomeTaskByIdAsync(Guid hometaskId, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return _taskRepository.GetHomeTaskByIdAsync(hometaskId, asNoTracking, cancellationToken);
    }

    public ValueTask<IList<HomeTask>> GetHomeTaskByIdsAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        return _taskRepository.GetHomeTaskByIdsAsync(ids, asNoTracking, cancellationToken);
    }
    public ValueTask<HomeTask> CreateAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _taskRepository.CreateAsync(homeTask, saveChanges, cancellationToken);
    }

    public ValueTask<HomeTask> UpdateAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _taskRepository.UpdateAsync(homeTask, saveChanges, cancellationToken);
    }

    public ValueTask<HomeTask?> DeleteHomeTaskByIdAsync(Guid hometaskId, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _taskRepository.DeleteHomeTaskByIdAsync(hometaskId, saveChanges, cancellationToken);
    }

    public ValueTask<HomeTask?> DeleteAsync(HomeTask homeTask, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        return _taskRepository.DeleteAsync(homeTask, saveChanges, cancellationToken);
    }
}
