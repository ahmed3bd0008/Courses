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
        HttpResponse<int> addCurrency(addCurrencyDto languageDto);
        Task <HttpResponse<int>> addAsyncCurrency(addCurrencyDto languageDto);

        Task< HttpResponse<CurrencyDto>>GetCurrency(string Language);
        Task< HttpResponse<CurrencyDto>>GetCurrency(Guid Language);

        Task< HttpResponse<List< CurrencyDto>>>GetCurrencies();
         
    }
}