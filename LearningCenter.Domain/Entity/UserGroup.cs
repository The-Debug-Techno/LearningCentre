namespace LearningCenter.Domain.Entity;

public class UserGroup: Auditable
{
    public Guid UserId { get; set; }
    
    public Guid GroupId { get; set; }
}