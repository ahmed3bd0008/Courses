using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity.Course;
namespace Repository.Interfacies
{
    public interface ICourseTypeRepo:IGenericRepo<CourseType>
    {
          Task< IEnumerable<CourseType>> GetCourseType();
           Task <IEnumerable<CourseType>> GetCourseType(string courseCategory);
           Task<CourseType> GetCourseTypeId(Guid id);
    }
}