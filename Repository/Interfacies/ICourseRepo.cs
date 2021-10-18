using Core.Entity.Course;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Interfacies
{
    public interface ICourseRepo:IGenericRepo<Course>
    {
       Task<Course> GetCourse(Guid Id);
        Task <IEnumerable<Course>> GetCourses();
        Task <IEnumerable<Course>> GetCourses(Expression<Func<Course,bool>>expression);
        Task <IEnumerable<Course>> GetCoursespres();
        Task <IEnumerable<Course>> GetCoursespres(String courseName);
    }
}