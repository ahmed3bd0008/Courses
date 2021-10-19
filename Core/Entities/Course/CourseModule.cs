using System;
using Core.Entity.Comman;
namespace Core.Entity.Course
{
    public class CourseModule:BaseEntity
    {
        public Guid CourseId { get; set; }
        public Guid ModuleId{get;set;}
        public Course Course { get; set; }
        public Module Module { get; set; }

    }
}