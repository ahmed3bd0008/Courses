using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Interfacies;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseAssistantController : ControllerBase
    {

        private readonly ILogger<CourseAssistantController> _logger;
        private readonly ICourseAssistant _courseAssistant;

                        public CourseAssistantController(ILogger<CourseAssistantController> logger,
                                            ICourseAssistant courseAssistant)
        {
            _logger = logger;
            _courseAssistant=courseAssistant;
        }
        [HttpPost("CreateInstructor")]
        public IActionResult CreateInstructor(AddInstructorDto instructorDto)
        {
            return Ok (_courseAssistant.addInstructor(instructorDto));
        }
        [HttpGet("GetInstructorById")]
        public async Task <IActionResult >GetInstructorId(Guid Id)
        {
            return Ok (await _courseAssistant.GetInstructor(Id));
        }
        [HttpGet("GetInstructorName")]
        public async Task <IActionResult >GetInstructorName(string Name)
        {
            return Ok (await _courseAssistant.GetInstructor(Name));
        }
        [HttpGet("GetInstructor")]
        public async Task <IActionResult >GetInstructor( )
        {
            return Ok (await _courseAssistant.GetInstructor());
        }
    ////////
      [HttpPost("CreateModule")]
        public IActionResult CreateModule(AddModuleDto moduleDto)
        {
            return Ok (_courseAssistant.addModule(moduleDto));
        }
        [HttpGet("GetModuleById")]
        public async Task <IActionResult >GetModuleId(Guid Id)
        {
            return Ok (await _courseAssistant.GetModule(Id));
        }
        [HttpGet("GetModuleName")]
        public async Task <IActionResult >GetModuleName(string Name)
        {
            return Ok (await _courseAssistant.GetModule(Name));
        }
        [HttpGet("GetModule")]
        public async Task <IActionResult >GetModule( )
        {
            return Ok (await _courseAssistant.GetModule());
        } 
        ////// 
        [HttpPost("CreateSkill")]
        public IActionResult CreateSkill(AddSkillDto skillDto)
        {
            return Ok (_courseAssistant.addSkill(skillDto));
        }
        [HttpGet("GetSkillById")]
        public async Task <IActionResult >GetSkillId(Guid Id)
        {
            return Ok (await _courseAssistant.GetSkill(Id));
        }
        [HttpGet("GetSkillName")]
        public async Task <IActionResult >GetSkillName(string Name)
        {
            return Ok (await _courseAssistant.GetSkill(Name));
        }
        [HttpGet("GetSkill")]
        public async Task <IActionResult >GetSkill( )
        {
            return Ok (await _courseAssistant.GetSkill());
        } 
    }
}
