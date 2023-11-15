namespace LearningCenter.Domain.Entity;

public class User : Auditable
{
    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;
    
    public string EmailAddress { get; set; } = default!;
    
    public DateTime DateOfBirth { get; set; } = default!;
    
    public bool IsActive { get; set; }
    
    public Guid RoleId { get; set; }
}
