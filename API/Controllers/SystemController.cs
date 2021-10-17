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
                        private readonly ISystemService _systemService;

                        public SystemController(ILogger<SystemController> logger,
        ISystemService systemService)
        {
            _logger = logger;
            _systemService=systemService;
        }

        [HttpPost("AddLanguage")]
        public IActionResult AddLaguage(AddLanguageDto languageDto)
        {
           _systemService.addLanguage(languageDto);
           return Ok();
        }
        [HttpGet("GetAllLanguage")]
        public async Task< IActionResult> Get()
        {
           
           return Ok(await _systemService.GetLanguageies());
        }
        [HttpGet("GetLanguage")]
        public async Task< IActionResult> GetLanguage(string laguage)
        {
           
           return Ok(await _systemService.GetLanguage(laguage));
        }
         [HttpGet("GetLanguageId")]
        public async Task< IActionResult> GetLanguageId(Guid Id)
        {
           
           return Ok(await _systemService.GetLanguageId(Id));
        }
        [HttpPost("AddCurrency")]
         public IActionResult AddCurrency(addCurrencyDto currencyDto)
        {
           _systemService.addCurrency(currencyDto);
           return Ok();
        }
        [HttpGet("GetCurrencies")]
        public async Task< IActionResult> GetCurrencies()
        {
           
           return Ok(await _systemService.GetCurrencies());
        }
    }
}
