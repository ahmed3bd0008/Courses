using System.Collections.Generic;
using Core.Entity.Comman;

namespace Core.Entity.Course
{
    public class CourseCategory:BaseNameEntity
    {
        public ICollection< Course> Courses { get; set; }
    }
}