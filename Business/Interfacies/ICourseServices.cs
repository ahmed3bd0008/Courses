using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.HttpResponse;
using Core.Dto;
namespace Business.Interfacies
{
    public interface ICourseServices
    {
        HttpResponse<int> addCourse(AddCourseDto courseDto);
        Task <HttpResponse<int>> addAsyncCourse(AddCourseDto courseDto);

        Task< HttpResponse<List< CourseDto>>>GetCourses(string Course);
        Task< HttpResponse<CourseDto>>GetCourseById(Guid Course);

        Task< HttpResponse<List< CourseDto>>>GetCourses();
    }
}