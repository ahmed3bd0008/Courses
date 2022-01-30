using System;
using System.Collections.Generic;

namespace Core.Dto.UserDto
{
    public class LoginUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class RegisterUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Introduction { get; set; }
        public DateTime LastActivity { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Guid ? CityId { get; set; }
     
    }
       public class UserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public int Age { get; set; }
        public string Introduction { get; set; }
        public DateTime LastActivity { get; set; }
        public IList<PhotoDto> Photos { get; set; }
        public Guid CityId { get; set; }
        public string City { get; set; }
        public Guid counteryId { get; set; }

        public string countery { get; set; }
        public string Phone { get; set; }
        public string MainPhoto { get; set; }
    }
    public class UserToken
    {
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}