namespace LearningCenter.Domain.Entity;

public class UserCourse: Auditable
{
    public Guid UserId { get; set; }
    
    public Guid CourseId { get; set; }
}