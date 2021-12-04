using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfacies.Authencation;
using Core.Dto.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthencationsController : ControllerBase
    {
        private readonly ILogger<AuthencationsController> _logger;
                        private readonly IAuthentcationManger _authentcationManger;

                        public AuthencationsController(ILogger<AuthencationsController> logger,
                        IAuthentcationManger authentcationManger        )
        {
                    _authentcationManger=authentcationManger;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(RegisterUserDto registerUserDto  )
        {
                    
            return Ok(await _authentcationManger.CreateUser(registerUserDto));
        }
        [HttpPost("logInUse")]
          public async Task<IActionResult> LogInUse(LoginUserDto loginUserDto )
        {
                    
            return Ok(await _authentcationManger.LogenUser(loginUserDto));
        }
        [HttpGet("GetAllUser")]
        public async Task<IActionResult>GetAllUser(){
            return Ok(await _authentcationManger.GetUserAsync());
        }

    }
}