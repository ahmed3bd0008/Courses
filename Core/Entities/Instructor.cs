using System.Collections.Generic;
using Core.Entity.Comman;
using Core.Entity.Course;

namespace Core.Entity
{
    public class Instructor:BaseNameEntity
    {
        public System.Guid CourseInstructorId { get; set; }
        public ICollection< CourseInstructor> CourseInstructor { get; set; }
    }
}