namespace LearningCenter.Domain.Entity;

public class Groups: BaseModel
{
    public string Name { get; set; } = default!;
    
    public string Description { get; set; } = default!;
    
    public DateTime StartDate { get; set; } = default!;
    
    public DateTime EndDate { get; set; } = default!;
    
    public Guid CourseId { get; set; } = default!;
}