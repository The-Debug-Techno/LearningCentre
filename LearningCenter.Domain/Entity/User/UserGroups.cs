namespace LearningCenter.Domain.Entity;

public class UserGroups: BaseModel
{
    public Guid UserId { get; set; }
    
    public Guid GroupId { get; set; }
}