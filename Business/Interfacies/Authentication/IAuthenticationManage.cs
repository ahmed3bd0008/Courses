using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Dto.UserDto;
using Core.Entity.User;

namespace Business.Interfacies.Authencation
{
    public interface IAuthentcationManger
    {
        public AppUser user { get; set; }
        Task<int>CreateUser(RegisterUserDto registerUserDto);
        Task<UserToken>LogenUser(LoginUserDto loginUserDto);
        Task<bool>VaildUser(LoginUserDto loginUserDto);
         public  Task< List<UserDto>>GetUserAsync();
         public  Task< UserDto>GetUserByUserNameAsync(string UserName);
    }
}