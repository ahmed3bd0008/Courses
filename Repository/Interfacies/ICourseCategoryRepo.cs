using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity.Course;
namespace Repository.Interfacies
{
    public interface ICourseCategoryRepo:IGenericRepo<CourseCategory>
    {
          Task< IEnumerable<CourseCategory>> GetCategory();
           Task <IEnumerable<CourseCategory>> GetCategory(string courseCategory);
           Task<CourseCategory> GetCategoryId(Guid id);
    }
}