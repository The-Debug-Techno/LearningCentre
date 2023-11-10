using LearningCenter.Domain.Common;

namespace LearningCenter.Domain.Entity;

public abstract class Auditable : IEntity
{
    public Guid Id { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(5);
    
    public DateTime UpdatedAt { get; set; }
}