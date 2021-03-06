using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.HttpResponse;
using Business.Interfacies;
using Core.Dto;
using Core.Entity;
using Core.Paging;
using Repository.Interfacies;

namespace Business.Implemenation
{
            public class SystemService : ISystemService
            {
                        private readonly IMangerRepo _mangerRepo;
                        private readonly IMapper _mapper;
                        public SystemService(IMangerRepo mangerRepo,IMapper mapper)
                        {
                            _mangerRepo=mangerRepo;
                            _mapper=mapper;
                        }
                        public async Task<HttpResponse<int>> addAsyncLanguage(AddLanguageDto languageDto)
                        {
                                    var language=_mapper.Map<Language>(languageDto);
                                    await _mangerRepo.LanguageRepo.AddAsync(language);
                                    await _mangerRepo.saveAsync();
                                    return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public HttpResponse<int> addLanguage(AddLanguageDto languageDto)
                        {
                                   var Language=_mapper.Map<Language>(languageDto);
                                   _mangerRepo.LanguageRepo.Add(Language);
                                   _mangerRepo.save();
                                   return new HttpResponse<int>(){Status=true,Data=1};
                        }
                        public async Task<HttpResponse<LanguageDto>> GetLanguage(string Language)
                        {
                                   var LanguageDb= await _mangerRepo.LanguageRepo.GetLanguage(Language);
                                    var LanguageDto=_mapper.Map< LanguageDto>(LanguageDb);
                                    return new HttpResponse<LanguageDto>{Status=true,Data= LanguageDto};

                        }
                         public async Task<HttpResponse<LanguageDto>> GetLanguageId(Guid Id)
                        {
                                   var LanguageDb= await _mangerRepo.LanguageRepo.GetLanguageId(Id);
                                    var LanguageDto=_mapper.Map< LanguageDto>(LanguageDb);
                                    return new HttpResponse<LanguageDto>{Status=true,Data= LanguageDto};

                        }
                        public async Task< HttpResponse<List< LanguageDto>>>GetLanguageies()
                        {
                                    var languages = await _mangerRepo.LanguageRepo.GetLanguageies();
                                    var LanguageDto=_mapper.Map<List< LanguageDto>>(languages);
                                    return new HttpResponse<List< LanguageDto>>{Status=true,Data= LanguageDto.ToList()};
                        }
                        //////////////currency
                        public async Task<HttpResponse<int>> addAsyncCurrency(addCurrencyDto currancyDto)
                        {
                                    var currency=_mapper.Map<Currency>(currancyDto);
                                     await _mangerRepo.CurrencyRepo.AddAsync(currency);
                                    await _mangerRepo.saveAsync();
                                    return new HttpResponse<int>{Status=true,Data=1};
                        }
                         public HttpResponse<int> addCurrency(addCurrencyDto currencyDto)
                        {
                                    var currency=_mapper.Map<Currency>(currencyDto);
                                    _mangerRepo.CurrencyRepo.Add(currency);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>{Status=true,Data=1};
                        }
                         public async Task<HttpResponse<List<CurrencyDto>>> GetCurrencies()
                        {
                                   var currency=await _mangerRepo.CurrencyRepo.GetCurrencies();
                                   var currenciesDto=_mapper.Map<List<CurrencyDto>>(currency);
                                   return new HttpResponse<List<CurrencyDto>>{Status=true,Data=currenciesDto};
                        }

                        public async Task<HttpResponse<List<CurrencyDto>>> GetCurrency(string currancyName)
                        {
                                   var currency=await _mangerRepo.CurrencyRepo.GetCurrencies(currancyName);
                                   var currenciesDto=_mapper.Map<List<CurrencyDto>>(currency);
                                   return new HttpResponse<List<CurrencyDto>>{Status=true,Data=currenciesDto};
                        }
                        public async Task<HttpResponse<CurrencyDto>> GetCurrency(Guid currancyId)
                        {
                                   var currency=await _mangerRepo.CurrencyRepo.GetCurrencyById(currancyId);
                                   var currenciesDto=_mapper.Map<CurrencyDto>(currency);
                                   return new HttpResponse<CurrencyDto>{Status=true,Data=currenciesDto};
                        }
                    ////////////////countery
                        public HttpResponse<int> addCountery(AddCountryDto countryDto)
                        {
                                    var Countery=_mapper.Map<Countery>(countryDto);
                                    _mangerRepo.CounteryRepo.Add(Countery);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>{Status=true,Data=1};
                        }

                        public async Task<HttpResponse<int>> addAsyncCountery(AddCountryDto countryDto)
                        {
                                     var Countery=_mapper.Map<Countery>(countryDto);
                                     await _mangerRepo.CounteryRepo.AddAsync(Countery);
                                     await _mangerRepo.saveAsync();
                                    return new HttpResponse<int>{Status=true,Data=1};
                        }

                        public async Task<HttpResponse<List<CounteryDto>>> GetCountery(string countryName)
                        {
                                   var counteries=await _mangerRepo.CounteryRepo.GetCountery(countryName);
                                   var counteriesDto=_mapper.Map<List<CounteryDto>>(counteries);
                                   return new HttpResponse<List<CounteryDto>>{Status=true,Data=counteriesDto};
                        }

                        public async Task<HttpResponse<CounteryDto>> GetCounter(Guid countryId)
                        {
                                   var countery=await _mangerRepo.CounteryRepo.GetCountery(countryId);
                                   var counteryDto=_mapper.Map<CounteryDto>(countery);
                                   return new HttpResponse<CounteryDto>{Status=true,Data=counteryDto};
                        }

                        public async Task<HttpResponse<List<CounteryDto>>> GetCountery()
                        {
                                  var counteries=await _mangerRepo.CounteryRepo.GetCountery();
                                   var counteriesDto=_mapper.Map<List<CounteryDto>>(counteries);
                                   return new HttpResponse<List<CounteryDto>>{Status=true,Data=counteriesDto,Message="important"};
                        }
                         public async Task<HttpResponse<PagingList<CounteryDto>>> GetCountery(RequestCounteryPrameter counteryPrameter)
                        {
                                  var counteries=await _mangerRepo.CounteryRepo.GetCounteryOrderByName(counteryPrameter);
                                  var CounteriesDto=_mapper.Map<List<CounteryDto>>(counteries);
                                  var counteryPaging= PagingList<CounteryDto>.ToPageList(Source:CounteriesDto,PageIndex:counteryPrameter.PageNumber,PageSize:counteryPrameter.PageSize);

                                   return new HttpResponse<PagingList<CounteryDto>>
                                       { Status = true,Data=counteryPaging, Message = "important"};
                        }

                        public HttpResponse<int> addCity(AddCityDto cityDto)
                        {
                                    var ExistCity= _mangerRepo.CityRepo.findCitycity(cityDto.Name,cityDto.CounteryId);
                                    if(ExistCity !=null) return new HttpResponse<int>{Status=false,Data=0,Message="exist city"};
                                    var city=_mapper.Map<City>(cityDto);
                                    _mangerRepo.CityRepo.Add(city);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>{Status=true,Data=1};
                        }

                        public async Task<HttpResponse<int>> addAsyncCity(AddCityDto cityDto)
                        {
                                     var city=_mapper.Map<City>(cityDto);
                                     await _mangerRepo.CityRepo.AddAsync(city);
                                     await _mangerRepo.saveAsync();
                                    return new HttpResponse<int>{Status=true,Data=1};
                        }

                        public async Task<HttpResponse<List<CityDto>>> GetCity(string cityName)
                        {
                                     var cities=await _mangerRepo.CityRepo.GetCity();
                                   var citiesDto=_mapper.Map<List<CityDto>>(cities);
                                   return new HttpResponse<List<CityDto>>{Status=true,Data=citiesDto};
                        }

                        public async Task<HttpResponse<CityDto>> GetCity(Guid cityId)
                        {
                                     var cities=await _mangerRepo.CityRepo.GetCity(cityId);
                                   var citiesDto=_mapper.Map<CityDto>(cities);
                                   return new HttpResponse<CityDto>{Status=true,Data=citiesDto};
                        }

                        public async Task<HttpResponse<List<CityDto>>> GetCity()
                        {
                                   var cities=await _mangerRepo.CityRepo.GetCity();
                                   var citiesDto=_mapper.Map<List<CityDto>>(cities);
                                   return new HttpResponse<List<CityDto>>{Status=true,Data=citiesDto};
                        }
                        public async Task<HttpResponse<List<CityCounteryDto>>> GetCounteryWithCity()
                        {
                                   var counteries=await _mangerRepo.CounteryRepo.GetCounteryWithCitIes();
                                   var counteriesDto=_mapper.Map<List<CityCounteryDto>>(counteries);
                                   return new HttpResponse<List<CityCounteryDto>>{Status=true,Data=counteriesDto};
                        }
                          public async Task<HttpResponse<List<counteryCitiesDto>>> GetCounteryWithCityfull()
                        {
                                   var counteries=await _mangerRepo.CounteryRepo.GetCounteriesFull();
                                   var counteriesDto=_mapper.Map<List<counteryCitiesDto>>(counteries);
                                   return new HttpResponse<List<counteryCitiesDto>>{Status=true,Data=counteriesDto};
                        }

        public async Task<HttpResponse<List<CitisCounteryDto>>> GetCityCounteryfull()
        {
             var cities=await _mangerRepo.CityRepo.GetCounteriesFull();
                                   var counteriesDto=_mapper.Map<List<CitisCounteryDto>>(cities);
                                   return new HttpResponse<List<CitisCounteryDto>>{Status=true,Data=counteriesDto ,Message=counteriesDto.Count.ToString()};
        }
         public async Task<HttpResponse<List<CityDto>>> GetCounteryCitiesByName(string couteryName)
        {
            var cityDb=await _mangerRepo.CityRepo.GetcountryCitiesByName( couteryName);
             var cityDto=_mapper.Map<List<CityDto>>(cityDb);
             return new HttpResponse<List<CityDto>>(){Data=cityDto,Status=true,Message="success"};
        }

        public async Task<HttpResponse<List<CityDto>>> GetCounteryCitiesById(Guid counteryId)
        {
             var cityDb=await _mangerRepo.CityRepo.GetcountryCitiesById( counteryId);
             var cityDto=_mapper.Map<List<CityDto>>(cityDb);
             return new HttpResponse<List<CityDto>>(){Data=cityDto,Status=true,Message="success"};
        }
        public async Task<HttpResponse<UpdateCity>> updateCity(UpdateCity updateCity)
        {
          try{
          var city =await _mangerRepo.CityRepo.GetCity(updateCity.Id);
           if(city==null) return new HttpResponse<UpdateCity>(){Status=false, Message="data is empity"};
           var  existingCity=await _mangerRepo.CityRepo.findCitycityAsync(updateCity.Name,updateCity.CounteryId);
           if(existingCity!=null) return new HttpResponse<UpdateCity>(){Status=false,Message="this countery is existing"};
           var cityDb=_mapper.Map<City>(updateCity);
            _mangerRepo.CityRepo.Update(cityDb);
            int success=await _mangerRepo.saveAsync();
            if(success<1) return new HttpResponse<UpdateCity>(){Status=false, Message="error on save"};
            return new HttpResponse<UpdateCity>(){Message="success",Status=true};
          }
          catch(Exception EX)
          {
            return new HttpResponse<UpdateCity>(){Status=false,Message=EX.Message};
          }
        }
        public async  Task<HttpResponse<int>>DeleteCity(Guid CityId){
          var cityDb= await _mangerRepo.CityRepo.GetCity(CityId);
          if(cityDb==null) return new HttpResponse<int>(){Status=false,Message="thier is no cit with this Id"};
          _mangerRepo.CityRepo.Delete(cityDb);
          var stat=await _mangerRepo.saveAsync();
          if(stat<1)return new HttpResponse<int>(){Status=false,Message="Erro Happen When Delete"};
          return new HttpResponse<int>(){Message="City Is Deleted",Status=true,Data=1};
        }

       
    }
            
}