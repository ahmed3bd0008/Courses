using System.Threading.Tasks;
using Core.Dto.UserDto;
using Core.Entity.User;

namespace Business.Interfacies.Authencation
{
    public interface IAuthentcationManger
    {
          public AppUser user { get; set; }
        Task<bool>VaildUser(LoginUserDto loginUserDto);
        Task<string>CreateToken();
    }
}