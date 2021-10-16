using Microsoft.EntityFrameworkCore;
using Core.Entity;
using Core.Entity.Course;
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
    }
}