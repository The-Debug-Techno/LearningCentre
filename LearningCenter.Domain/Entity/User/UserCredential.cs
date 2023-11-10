namespace LearningCenter.Domain.Entity;

public class UserCredential : BaseModel
{
    public string PasswordHash { get; set; } = default!;
    
    public Guid UserId { get; set; } = default!;
}