using LearningCenter.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LearningCenter.Persistence.DataContexts;

public class AppDbContext : DbContext
{
    DbSet<User> Users => Set<User>();
    DbSet<Role> Roles => Set<Role>();
    DbSet<Course> Courses => Set<Course>();
    DbSet<Group> Groups => Set<Group>();
    DbSet<HomeTask> HomeTasks  => Set<HomeTask>();
    DbSet<UserCredential> UserCrdentials => Set<UserCredential>();
    DbSet<UserCourse> UserCourses => Set<UserCourse>();
    DbSet<UserGroup> UserGroups => Set<UserGroup>();
    DbSet<StudentHomeTask> StudentHomeTasks => Set<StudentHomeTask>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
