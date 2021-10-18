using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Business.Interfacies;
using Core.Dto;
namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
                        private readonly ICourseServices _courseServices;

                        public CourseController(ILogger<CourseController> logger,
                                    ICourseServices courseServices
        )
        {
            _logger = logger;
            _courseServices=courseServices;
        }
        [HttpPost("CreateCourse")]
        public IActionResult CreateCourse(AddCourseDto courseDto)
        {
            return Ok (_courseServices.addCourse(courseDto));
        }
        [HttpGet("GetCourse")]
        public async Task <IActionResult >GetCourseId(Guid Id)
        {
            return Ok (await _courseServices.GetCourseById(Id));
        }
         [HttpGet("GetCourseName")]
        public async Task <IActionResult >GetCourseName(string Name)
        {
            return Ok (await _courseServices.GetCourses(Name));
        }
       
      
    }
}
