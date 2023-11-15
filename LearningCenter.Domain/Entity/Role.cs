namespace LearningCenter.Domain.Entity;

public class Role : Auditable
{ 
    public UserRole RoleType { get; set; }
    public bool IsDisabled { get; set; }
}
