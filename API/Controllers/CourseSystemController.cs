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
        [HttpPost("AddCourseType")]
        public  IActionResult AddCourseType(AddCourseTypeDto courseTypeDto)
        {

            _systemServiceCourse.addCourseType(courseTypeDto);
            return Ok(1);
        }
    }
}
