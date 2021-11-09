using Core.Entity.Comman;
using System.Collections.Generic;
namespace Core.Entity
{
    public class Language:BaseNameEntity
    {
       public ICollection<  Course.Course >Course { get; set; }  
    }
}