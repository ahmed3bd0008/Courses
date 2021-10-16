using Core.Entity.Course;
using Repository.Context;
using Repository.Interfacies;

namespace Repository.Implementation
{
    public class CourseRepo:GenericRepo<Course>,ICourseRepo
    {
        public CourseRepo(AppDbContext context):base(context)
        {
            
        }
    }
}