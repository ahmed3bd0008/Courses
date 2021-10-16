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
    public class SystemController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SystemController> _logger;
                        private readonly ILanguageServes _languageServes;

                        public SystemController(ILogger<SystemController> logger,
        ILanguageServes languageServes)
        {
            _logger = logger;
            _languageServes=languageServes;
        }

        [HttpPost]
        public IActionResult Add(AddLanguageDto languageDto)
        {
           _languageServes.addLanguage(languageDto);
           return Ok();
        }
        [HttpGet]
        public async Task< IActionResult> Get()
        {
           
           return Ok(await _languageServes.GetLanguageies());
        }
        [HttpGet("GetLanguage")]
        public async Task< IActionResult> GetLanguage(string laguage)
        {
           
           return Ok(await _languageServes.GetLanguage(laguage));
        }
         [HttpGet("GetLanguageId")]
        public async Task< IActionResult> GetLanguageId(Guid Id)
        {
           
           return Ok(await _languageServes.GetLanguageId(Id));
        }
    }
}
