using LearningCenter.Domain.Common;

namespace LearningCenter.Domain.Entity;

public class Course: Auditable
{
    public string Title { get; set; } = default!;
    
    public string Description { get; set; } = default!;
}