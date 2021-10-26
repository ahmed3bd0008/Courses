using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfacies;
using Core.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseSystemController : ControllerBase
    {
        
        private readonly ILogger<SystemController> _logger;
        private readonly ISystemServiceCourse _systemServiceCourse;

        public CourseSystemController(ILogger<SystemController> logger,
        ISystemServiceCourse systemServiceCourse)
        {
            _logger = logger;
            _systemServiceCourse=systemServiceCourse;
        }
        [HttpGet("GetAllCourseLevel")]
        public async Task<IActionResult>GetAllCourseLevel()
        {
            return Ok(await _systemServiceCourse.GetCourseLevel());
        }
        [HttpGet("GetCourseLevelName")]
        public async Task<IActionResult>GetCourseLevelByName(string CourseLevelName)
        {
            return Ok(await _systemServiceCourse.GetCourseLevel(CourseLevelName));
        }
        [HttpGet("GetCourseLevelBId")]
        public async Task<IActionResult>GetAllCourseLevelById(Guid Id)
        {
            return Ok(await _systemServiceCourse.GetCourseLevel(Id));
        }
        [HttpPost("AddCourseLevel")]
        public  IActionResult AddCourseLevel(AddCourseLevelDto courseLevelDto)
        {

            _systemServiceCourse.addCourseLevel(courseLevelDto);
            return Ok(1);
        }

        [HttpGet("GetAllCourseStatus")]
        public async Task<IActionResult>GetAllCourseStatus()
        {

            return Ok(await _systemServiceCourse.GetCourseStatus());
        }
        [HttpGet("GetCourseStatusName")]
        public async Task<IActionResult>GetAllCourseStatus(string statusName)
        {

            return Ok(await _systemServiceCourse.GetCourseStatus(statusName));
        }
        [HttpGet("GetCourseStatusById")]
        public async Task<IActionResult>GetCourseStatusById(Guid Id)
        {
            return Ok(await _systemServiceCourse.GetCourseStatus(Id));
        }
        [HttpPost("AddCourseStatus")]
        public  IActionResult AddCourseStatus(AddCourseStatusDto courseStatusDto)
        {
            _systemServiceCourse.addCourseStatus(courseStatusDto);
            return Ok(1);
        }   
        [HttpGet("GetAllCourseType")]
        public async Task<IActionResult>GetAllCourseType()
        {
            return Ok(await _systemServiceCourse.GetCourseType());
        }
        [HttpGet("GetCourseTypeBYId")]
        public async Task<IActionResult>GetCourseTypeById(Guid Id)
        {
            return Ok(await _systemServiceCourse.GetCourseType(Id));
        }
        [HttpGet("GetCourseTypeName")]
        public async Task<IActionResult>GetCourseTypeName(string CoursTypeName )
        {
            return Ok(await _systemServiceCourse.GetCourseType(CoursTypeName));
        }
        [HttpPost("AddCourseType")]
        public  IActionResult AddCourseType(AddCourseTypeDto courseTypeDto)
        {

            _systemServiceCourse.addCourseType(courseTypeDto);
            return Ok(1);
        }
        [HttpGet("GetAllCourseCategory")]
        public async Task<IActionResult>GetAllCourseCategory()
        {

            return Ok(await _systemServiceCourse.GetCourseCategory());
        }
        [HttpGet("GetCourseCategoryName")]
        public async Task<IActionResult>GetAllCourseCategory(string courseCategoryName)
        {

            return Ok(await _systemServiceCourse.GetCourseCategory(courseCategoryName));
        }
        [HttpGet("GetCourseCategoryById")]
        public async Task<IActionResult>GetCourseCategoryById(Guid Id)
        {
            return Ok(await _systemServiceCourse.GetCourseCategory(Id));
        }
        [HttpPost("AddCourseCategory")]
        public  IActionResult AddCourseCategory(AddCourseCategoryDto courseCategoryDto)
        {
            _systemServiceCourse.addCourseCategory(courseCategoryDto);
            return Ok(1);
        }   
    }
}
