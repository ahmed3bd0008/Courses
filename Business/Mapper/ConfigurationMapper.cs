using System.Linq;
using AutoMapper;
using Core.Dto;
using Core.Dto.UserDto;
using Core.Entity;
using Core.Entity.Course;
using Core.Entity.User;

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
            CreateMap<Countery, counteryCitiesDto>().ReverseMap();
            CreateMap<City, CitisCounteryDto>().ReverseMap();
            CreateMap<City,UpdateCity>().ReverseMap();
            CreateMap<AppUser,RegisterUserDto>().ReverseMap();

            CreateMap <Photo,PhotoDto>().ReverseMap();


            CreateMap<AppUser,UserDto>().
            ForMember(d=>d.Phone,m=>m.
            MapFrom(o=>o.Photos.FirstOrDefault(d=>d.IsMain))).
            ForMember(d=>d.Age,m=>m.MapFrom(d=>d.GetAge())).
            ForMember(d=>d.City,m=>m.MapFrom(d=>d.City.Name)).
            ForMember(d=>d.Phone,m=>m.MapFrom(d=>d.PhoneNumber)).
            ForMember(d=>d.MainPhoto,m=>m.MapFrom(d=>d.Photos.FirstOrDefault(k=>k.IsMain==true).Url)).
            ReverseMap();
            
        }
    }
}