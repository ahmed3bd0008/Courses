using System;

namespace Core.Dto
{
    public class InstructorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
     public class AddInstructorDto
    {
            public string Name { get; set; }
    }
}