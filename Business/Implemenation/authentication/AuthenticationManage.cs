using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Business.Configuration;
using Business.Interfacies.Authencation;
using Core.Dto.UserDto;
using Core.Entity.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Business.Implemenation.authentication
{
    public class AuthentcationManger:IAuthentcationManger
    {
        private readonly IConfiguration _config;
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfigurationSection _serviceKey;
        private readonly JwtSettings _jwtSettings;
        private readonly RoleManager<AppRole> _roleManager;

        public  AuthentcationManger(IConfiguration config,
         UserManager<AppUser> userManager,
         IOptionsMonitor<JwtSettings>jwtSettings,
         RoleManager<AppRole>roleManager)
        {
            _config = config;
            _userManager = userManager;
            _serviceKey = _config.GetSection("JwtSettings");
            _jwtSettings=jwtSettings.CurrentValue;
            _roleManager=roleManager;
        }
        public AppUser user { get; set; }
        public async Task<int> CreateUser(RegisterUserDto registerUserDto)
            {
                   AppUser appUser=new (){
                        UserName=registerUserDto.UserName,
                        Email=registerUserDto.Email,
                        PhoneNumber=registerUserDto.Phone
                   };
                   var res= await _userManager.CreateAsync(appUser,registerUserDto.Password);
                   if(res.Succeeded)
                   {
                       var xx=await _roleManager.RoleExistsAsync("role");
                        await _userManager.AddToRoleAsync(appUser,"role");
                        return 1;
                   }
                  StringBuilder ErrorString=new StringBuilder();
                  foreach (var error in res.Errors)
                  {
                      ErrorString.Append($"this is error {error.Description}");
                  }
                  return 0;
            }
        public async Task<UserToken> LogenUser(LoginUserDto loginUserDto)
            {
                    if(await VaildUser(loginUserDto))
                    {
                        return new UserToken(){UserName=loginUserDto.UserName,Token=await CreateToken()};
                    }
            return new UserToken(){UserName=null};
            }
        
        private async Task<string> CreateToken()
        {
            var signingCredentials = getSigningCredentials();
            var claims = await getClaims();
            var tokenOptions = generatToken(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
        public async Task<bool> VaildUser(LoginUserDto loginUserDto)
        {
            user = await _userManager.FindByNameAsync(loginUserDto.UserName);
            return (user != null && await _userManager.CheckPasswordAsync(user, loginUserDto.Password));
        }
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_config["JwtSettings:Key"].ToString());
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private SigningCredentials getSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_config["JwtSettings:Key"].ToString());
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> getClaims()
        {
            List<Claim> claims = new();
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            IList<string> roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim> {
            new Claim(ClaimTypes.Name, user.UserName) };
            var roles = await _userManager.GetRolesAsync(user); foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        private JwtSecurityToken generatToken(SigningCredentials signingCredentials, List<Claim> claims)
        {
            JwtSecurityToken jwtSecurityToken = new
            (
                issuer: _serviceKey.GetSection("validIssuer").Value,
                audience: _serviceKey.GetSection("validAudience").Value,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.Now.AddDays(Convert.ToDouble(_serviceKey.GetSection("expires").Value))

            );
            return jwtSecurityToken;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _config.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken(
            issuer: jwtSettings.GetSection("validIssuer").Value, 
            audience: jwtSettings.GetSection("validAudience").Value, claims: claims, expires:
            DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)), signingCredentials: signingCredentials
            ); return tokenOptions;
        }                   
    }
}