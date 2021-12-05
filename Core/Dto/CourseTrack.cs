using System;

namespace Core.Dto
{
    public class CourseTrackDto
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
    }
     public class AddCourseTrackDto
    {
        public string  Name { get; set; }
    }
}