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
            CreateMap<CourseStatus,AddCourseStatusDto>().ReverseMap();
            CreateMap<CourseStatus,CourseStatusDto>().ReverseMap();
            CreateMap<CourseType,AddCourseTypeDto>().ReverseMap();
            CreateMap<CourseType,CourseTypeDto>().ReverseMap();
            CreateMap<Course,CourseDto>().ReverseMap();
            CreateMap<Module,ModuleDto>().ReverseMap();
            CreateMap<Module,AddModuleDto>().ReverseMap();
            CreateMap<Instructor,InstructorDto>().ReverseMap();
            CreateMap<Instructor,AddInstructorDto>().ReverseMap();
            CreateMap<Skill,SkillDto>().ReverseMap();
            CreateMap<CourseCategory,CourseCategoryDto>().ReverseMap();
            CreateMap<CourseCategory,AddCourseCategoryDto>().ReverseMap();
            CreateMap<Countery,AddCountryDto>().ReverseMap();
            CreateMap<Countery,CounteryDto>().ReverseMap();
            CreateMap<City,AddCityDto>().ReverseMap();
            CreateMap<City,CityDto>().ReverseMap();
            CreateMap<City, CityCounteryDto>().ReverseMap();
            
        }
    }
}