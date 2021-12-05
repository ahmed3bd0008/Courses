using Core.Entity.Comman;
using System.Collections.Generic;
namespace Core.Entity.Course
{
    public class courseTrack:BaseNameEntity
    {
        public ICollection<Course> Courses { get; set; }
    }
}