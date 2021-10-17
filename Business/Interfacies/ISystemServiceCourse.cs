using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.HttpResponse;
using Core.Dto;

namespace Business.Interfacies
{
    public interface ISystemServiceCourse
    {
        HttpResponse<int> addCourseLevel(AddCourseLevelDto courseLevelDto);
        Task <HttpResponse<int>> addAsyncCourseLevel(AddCourseLevelDto courseLevelDto);

        Task< HttpResponse<CourseLevelDto>>GetCourseLevel(string courseLevel);
        Task< HttpResponse<CourseLevelDto>>GetCourseLevel(Guid courseLevel);

        Task< HttpResponse<List< CourseLevelDto>>>GetCourseLevel();
        
         
    }
}