using System;
namespace Core.Dto
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CourseDesc { get; set; }
        public Guid courseLevelId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid CurrencyId { get; set; }
        public CourseLevelDto courseLevelDto { get; set; }
        public CurrencyDto currencyDto { get; set; }
        public LanguageDto languageDto { get; set; }
        
    }
    public class AddCourseDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public string CourseDesc { get; set; }
        public Guid courseLevelId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid CurrencyId { get; set; }

    }
}