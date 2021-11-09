using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Core.Dto
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        IFormFile CoursePhoto { get; set; }
         public string CoursePromtLink { get; set; }
        public string CourseWebsit { get; set; }
        public bool Track { get; set; }
        public string Duration { get; set; }
        public string CourseRefrance { get; set; }
        public string CourseRefranceText { get; set; }
        public string CourseRefranceLink { get; set; }
        public int ? CourseCertificationNO { get; set; }
         public bool CertificationAvailable { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndData { get; set; }
        public string CourseDesc { get; set; }
        public Guid CourseStatusId { get; set; }
        public Guid CourseCategoryId { get; set; }
        public Guid CourseTypeId { get; set; }
        public Guid courseLevelId { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid LanguageId { get; set; }    
        public CourseLevelDto courseLevelDto { get; set; }
        public CurrencyDto currencyDto { get; set; }
        public LanguageDto languageDto { get; set; } 
    }
    public class AddCourseDto
    {
        public string Name { get; set; }
        [Required]
        public decimal ? Price { get; set; }
        public IFormFile CoursePho { get; set; } 
         public string CoursePromtLink { get; set; }
        public string CourseWebsit { get; set; }
        public bool Track { get; set; }
        public string Duration { get; set; }
        public string CourseRefrance { get; set; }
        public string CourseRefranceText { get; set; }
        public string CourseRefranceLink { get; set; }
        public int ? CourseCertificationNO { get; set; }
         public bool CertificationAvailable { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndData { get; set; }
        public string CourseDesc { get; set; }
        public Guid ?  CourseStatusId { get; set; }
        public Guid  CourseCategoryId { get; set; }
        public Guid ? CourseTypeId { get; set; }
        public Guid ? courseLevelId { get; set; }
        public Guid ? CurrencyId { get; set; }
        public Guid ? LanguageId { get; set; }    
    }
}
