using LearningCenter.Domain.Common;

namespace LearningCenter.Domain.Entity;

public class UserGroups: Auditable
{
    public Guid UserId { get; set; }
    
    public Guid GroupId { get; set; }
}