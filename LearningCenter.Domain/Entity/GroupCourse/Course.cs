namespace LearningCenter.Domain.Entity;

public class Course: BaseModel
{
    public string Title { get; set; } = default!;
    
    public string Description { get; set; } = default!;
}