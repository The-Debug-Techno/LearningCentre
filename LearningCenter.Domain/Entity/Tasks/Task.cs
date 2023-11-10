namespace LearningCenter.Domain.Entity.Tasks;

public class Task: Auditable
{
    public Guid GroupId { get; set; }
    
    public Guid TeacherId { get; set; }

    public bool IsActive { get; set; }
    
    public TimeSpan Duration { get; set; }
    
    public string Title { get; set; } = default!;
    
    public string Description { get; set; } = default!;
}