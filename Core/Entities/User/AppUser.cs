using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace Core.Entity.User
{
    public class AppUser: IdentityUser
    {
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime BirthDate { get; set; }
        public string Introduction { get; set; }
        public DateTime LastActivity { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Guid ? CityId { get; set; }
        public Guid RelationKey { get; set; }
        public City City { get; set; }
        public int GetAge(){
            var DateToDay=DateTime.Today;
            var age=DateToDay.Year-this.BirthDate.Year;
            return this.BirthDate.AddYears(age)>DateToDay?--age:age;
        }
    }
}