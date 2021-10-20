using System;
using System.Collections.Generic;
using Core.Entity.Comman;

namespace Core.Entity.Course
{
    public class Course:BaseNameEntity
    {
        public decimal Price { get; set; }
        public string CoursePhoto { get; set; }
        public string CoursePromtLink { get; set; }
        public string CourseWebsit { get; set; }
        public bool Track { get; set; }
        public string Duration { get; set; }
        public string CourseRefrance { get; set; }
        public string CourseRefranceText { get; set; }
        public string CourseRefranceLink { get; set; }
        public string CourseDesc { get; set; }
        public string CourseRequirement { get; set; }
        public int ourseCertificationNO { get; set; }
        public bool CertificationAvailable { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndData { get; set; }
        public Guid CourseStatusId { get; set; }
        public Guid CourseCategoryId { get; set; }
        public Guid CourseTypeId { get; set; }
        public Guid courseLevelId { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid LanguageId { get; set; }
        public CourseStatus CourseStatus { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public CourseType CourseType { get; set; }
        public CourseLevel CourseLevel { get; set; }
        public Currency currency { get; set; }
        public Language language { get; set; }
         public ICollection< CourseGainSkill >CourseGainSkills { get; set; }
        public ICollection< CourseRequiredSkill >CourseRequiredSkills { get; set; }
        public ICollection<CourseModule>CourseModules{set;get;}
        public ICollection<CourseInstructor>CourseInstructors{set;get;}
    }
}