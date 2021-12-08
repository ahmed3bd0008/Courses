using System.Threading.Tasks;
using Business.Interfacies.Authencation;
using Core.Dto.UserDto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>GetAllUser(){
            return Ok(await _authentcationManger.GetUserAsync());
        }
         [HttpGet("GetUserByUserName/{UserName}")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>GetUserByName(string UserName){
            return Ok(await _authentcationManger.GetUserByUserNameAsync(UserName));
        }

    }
}