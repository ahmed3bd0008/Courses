using Core.Entity.Comman;
using Core.Entity.Course;
using System.Collections.Generic;

namespace Core.Entity
{
    public class Module:BaseNameEntity
    {
         public System.Guid CourseModuleId { get; set; }
        public ICollection<CourseModule> CourseModule { get; set; }
    }
}