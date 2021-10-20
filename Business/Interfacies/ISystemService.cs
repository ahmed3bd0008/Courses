using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.HttpResponse;
using Core.Dto;

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
         
    }
}