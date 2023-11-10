namespace LearningCenter.Domain.Entity;

public class UserCredential : Auditable
{
    public string PasswordHash { get; set; } = default!;
    
    public Guid UserId { get; set; } = default!;
}