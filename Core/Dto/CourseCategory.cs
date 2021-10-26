using System;

namespace Core.Dto
{
    public class CourseCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class AddCourseCategoryDto
    {
        public string Name { get; set; }
    }

}