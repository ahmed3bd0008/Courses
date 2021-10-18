using AutoMapper;
using Core.Dto;
using Core.Entity;
using Core.Entity.Course;

namespace Business.Mapper
{
   public class ConfigurationMapper:Profile
    {
        public ConfigurationMapper()
        {
            CreateMap<Language,AddLanguageDto>().ReverseMap();
            CreateMap<Language,LanguageDto>().ReverseMap();
            CreateMap<Currency,CurrencyDto>().ReverseMap();
            CreateMap<Currency,addCurrencyDto>().ReverseMap();
            CreateMap<CourseLevel,CourseLevelDto>().ReverseMap();
            CreateMap<CourseLevel,AddCourseLevelDto>().ReverseMap();
            CreateMap<Course,AddCourseDto>().ReverseMap();
            CreateMap<Course,CourseDto>().ReverseMap();
        }
    }
}