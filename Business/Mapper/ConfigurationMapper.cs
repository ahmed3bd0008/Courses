using AutoMapper;
using Core.Dto;
using Core.Entity;
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
        }
    }
}