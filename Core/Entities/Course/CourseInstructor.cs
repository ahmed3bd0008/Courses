using System;
using Core.Entity.Comman;
namespace Core.Entity.Course
{
    public class CourseInstructor:BaseEntity
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}