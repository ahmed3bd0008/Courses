using System;

namespace Core.Dto
{
    public class SkillDto
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
    }
     public class AddSkillDto
    {
        public string  Name { get; set; }
    }
}