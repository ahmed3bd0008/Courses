using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity.Course;
namespace Repository.Interfacies
{
    public interface ICourseLevelRepo:IGenericRepo<CourseLevel>
    {
        Task<IEnumerable<CourseLevel>> GetCourseLevel();    
        Task<IEnumerable<CourseLevel>> GetCourseLevel(string courseLevelName);    
        Task <CourseLevel> GetCourseLevelById(Guid courseLevelId);    
    }
}