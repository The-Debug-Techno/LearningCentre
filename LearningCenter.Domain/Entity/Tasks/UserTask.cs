namespace LearningCenter.Domain.Entity.Tasks;

public class UserTask
{
    public Guid UserId { get; set; }
    
    public Guid TaskId { get; set; }
    
    public Guid GroupId { get; set; }

    public string? TaskFilePath { get; set; }
    
}