namespace LearningCenter.Domain.Entity;

public class UserCourse: BaseModel
{
    public Guid UserId { get; set; }
    
    public Guid CourseId { get; set; }
}