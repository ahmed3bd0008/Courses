using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity.Course;
namespace Repository.Interfacies
{
    public interface ICourseStatuseRepo:IGenericRepo<CourseStatus>
    {
          Task< IEnumerable<CourseStatus>> GetCourseStatus();
           Task <IEnumerable<CourseStatus>> GetCourseStatus(string courseCategory);
           Task<CourseStatus> GetCourseStatusId(Guid id);
    }
}