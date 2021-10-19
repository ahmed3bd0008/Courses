using Core.Entity.Comman;
using System;
namespace Core.Entity.Course
{
    public class CourseGainSkill:BaseEntity
    {
        public Guid CourseId { get; set; }
        public Guid SkillId { get; set; }
        public Course Course { get; set; }
        public Skill Skill { get; set; }
    }
}