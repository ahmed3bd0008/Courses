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

        Task< HttpResponse<List<CourseLevelDto>>>GetCourseLevel(string courseLevel);
        Task< HttpResponse<CourseLevelDto>>GetCourseLevel(Guid courseLevel);

        Task< HttpResponse<List< CourseLevelDto>>>GetCourseLevel();
        ////////CourseStatus
        HttpResponse<int> addCourseStatus(AddCourseStatusDto courseStatusDto);
        Task <HttpResponse<int>> addAsyncCourseStatus(AddCourseStatusDto courseStatusDto);

        Task< HttpResponse<List< CourseStatusDto>>>GetCourseStatus(string coursStatud);
        Task< HttpResponse<CourseStatusDto>>GetCourseStatus(Guid coursecoursStatud);

        Task< HttpResponse<List< CourseStatusDto>>>GetCourseStatus();
        
        /////////CourseLType
        
        HttpResponse<int> addCourseType(AddCourseTypeDto courseStatusDto);
        Task <HttpResponse<int>> addAsyncCourseType(AddCourseTypeDto courseStatusDto);

        Task< HttpResponse<List<CourseTypeDto>>>GetCourseType(string courseType);
        Task< HttpResponse<CourseTypeDto>>GetCourseType(Guid courseType);

        Task< HttpResponse<List<CourseTypeDto>>>GetCourseType();

      //Course Category
         HttpResponse<int> addCourseCategory(AddCourseCategoryDto categoryDto);
        Task <HttpResponse<int>> addAsyncCourseCategory(AddCourseCategoryDto courseCategoryDto);

        Task< HttpResponse<List<CourseCategoryDto>>>GetCourseCategory(string courseCategory);
        Task< HttpResponse<CourseCategoryDto>>GetCourseCategory(Guid courseCategoryId);

        Task< HttpResponse<List<CourseCategoryDto>>>GetCourseCategory();
         
    }
}