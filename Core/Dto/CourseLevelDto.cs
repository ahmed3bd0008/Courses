using System;

namespace Core.Dto
{
    public class CourseLevelDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class AddCourseLevelDto
    {
        public string Name { get; set; }
    }
}