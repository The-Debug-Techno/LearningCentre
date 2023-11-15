namespace LearningCenter.Domain.Entity;

public class StudentHomeTask
{
    public Guid UserId { get; set; }

    public Guid TaskId { get; set; }

    public Guid GroupId { get; set; }

    public string? TaskFilePath { get; set; }

}