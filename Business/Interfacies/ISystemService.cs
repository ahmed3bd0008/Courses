using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.HttpResponse;
using Core.Dto;
using Core.Paging;

namespace Business.Interfacies
{
    public interface ISystemService
    {
        HttpResponse<int> addLanguage(AddLanguageDto languageDto);
        Task <HttpResponse<int>> addAsyncLanguage(AddLanguageDto languageDto);

        Task< HttpResponse<LanguageDto>>GetLanguage(string Language);
        Task< HttpResponse<LanguageDto>>GetLanguageId(Guid Language);

        Task< HttpResponse<List< LanguageDto>>>GetLanguageies();
        HttpResponse<int> addCurrency(addCurrencyDto currancyDto);
        Task <HttpResponse<int>> addAsyncCurrency(addCurrencyDto currancyDto);

        Task< HttpResponse<List<CurrencyDto>>>GetCurrency(string currencyName);
        Task< HttpResponse<CurrencyDto>>GetCurrency(Guid currencyId);

        Task< HttpResponse<List< CurrencyDto>>>GetCurrencies();
         HttpResponse<int> addCountery(AddCountryDto countryDto);
        Task <HttpResponse<int>> addAsyncCountery(AddCountryDto countryDto);

        Task< HttpResponse<List<CounteryDto>>>GetCountery(string countryName);
        Task< HttpResponse<CounteryDto>>GetCounter(Guid countryId);

        Task< HttpResponse<List< CounteryDto>>>GetCountery();
        Task<HttpResponse<List<CounteryDto>>> GetCountery(RequestCounteryPrameter counteryPrameter);

        Task< HttpResponse<List<CityCounteryDto>>>GetCounteryWithCity();
        Task< HttpResponse<List<CityCounteryDto>>>GetCounteryWithCityfull();
        
         HttpResponse<int> addCity(AddCityDto cityDto);
        Task <HttpResponse<int>> addAsyncCity(AddCityDto cityDto);

        Task< HttpResponse<List<CityDto>>>GetCity(string cityName);
        Task< HttpResponse<CityDto>>GetCity(Guid cityId);

        Task< HttpResponse<List< CityDto>>>GetCity();
         
    }
}