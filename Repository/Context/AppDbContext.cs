using Microsoft.EntityFrameworkCore;
using Core.Entity;
using Core.Entity.Course;
using Repository.Configuration;

namespace Repository.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet< Language> Language { get; set; }
        public DbSet< Currency> Currency { get; set; }
        public DbSet< CourseCategory> CourseCategories { get; set; }
        public DbSet< CourseStatus> CourseStatuses { get; set; }
        public DbSet< CourseType> CourseTypes { get; set; }
          public DbSet< Instructor> Instructors { get; set; }
        public DbSet< Skill> Skills { get; set; }
        public DbSet< Module> Modules { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration( new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ModuleConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
             modelBuilder.ApplyConfiguration(new SkillConfiguration());
        }
       
    }
}