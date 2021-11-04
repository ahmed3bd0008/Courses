using Core.Entity.Comman;
using System;
namespace Core.Entity.Course
{
    public class CourseRequiredSkill:BaseEntity
    {
        public Guid CourseId { get; set; }
        public Guid SkillId { get; set; }
        public Course Course { get; set; }
        public Skill Skill { get; set; }
    }
}