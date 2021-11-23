using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfacies;
using Core.Dto;
using Core.Paging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
         [HttpPost("AddCountery")]
         public IActionResult AddCountery(AddCountryDto countryDto)
        {
          
           return Ok( _systemService.addCountery(countryDto));
        }
        [HttpGet("GetCounteries")]
        public async Task< IActionResult> GetCounteries()
        {
           
           return Ok(await _systemService.GetCountery());
        }
         [HttpGet("GetCounteriesPagingOrderByName")]
        public async Task<IActionResult>GetCounteriesPagingOrderByName( [FromQuery]RequestCounteryPrameter counteryPrameter)
        {
          return Ok(await _systemService.GetCountery(counteryPrameter));
        }
        [HttpGet("GetCounteriesCities")]
        public async Task< IActionResult> GetCounteriesCities()
        {
           
           return Ok(await _systemService.GetCounteryWithCity());
        }
         [HttpPost("AddCity")]
         public IActionResult addCity(AddCityDto cityDto)
        {
           return Ok(_systemService.addCity(cityDto));
        }
        [HttpGet("GetCities")]
        public async Task< IActionResult> getCities()
        {
           
           return Ok(await _systemService.GetCity());
        }
    }
}
