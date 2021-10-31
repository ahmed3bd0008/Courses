namespace Core.Dto.UserDto
{
    public class LoginUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class UserToken
    {
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}