using System;
using System.Collections.Generic;
using Core.Entity.Comman;
using Core.Entity.Course;

namespace Core.Entity
{
    public class Skill:BaseNameEntity
    {  
        public ICollection< CourseGainSkill> CourseGainSkills { get; set; }
        public ICollection< CourseRequiredSkill> CourseRequiredSkills { get; set; }
    }
}