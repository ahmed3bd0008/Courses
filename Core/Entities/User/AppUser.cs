using System;
using System.Collections.Generic;
using Core.Comman.ExtensionMethod;
using Microsoft.AspNetCore.Identity;
namespace Core.Entity.User
{
    public class AppUser: IdentityUser
    {
        public DateTime BithDate { get; set; }
        public DateTime LastActivity { get; set; }=DateTime.Now;
        public DateTime create { get; set; }=DateTime.Now;
        public string KnownAs { get; set; }
        public Guid CityId { get; set; }
        public string Introduction { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public City City { get; set; }
        public int GetAge(){
            return  BithDate.claculateAgeExtention();    
        }
        
    }
}