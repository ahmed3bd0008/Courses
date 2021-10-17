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
                        private readonly ISystemService _systemService;

                        public CourseSystemController(ILogger<SystemController> logger,
        ISystemService systemService)
        {
            _logger = logger;
            _systemService=systemService;
        }

       
    }
}
