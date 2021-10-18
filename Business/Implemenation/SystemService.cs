using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.HttpResponse;
using Business.Interfacies;
using Core.Dto;
using Core.Entity;
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

                       

                        public Task<HttpResponse<int>> addAsyncLanguage(AddLanguageDto languageDto)
                        {
                                    throw new System.NotImplementedException();
                        }

                       

                        public HttpResponse<int> addLanguage(AddLanguageDto languageDto)
                        {
                                   var Language=_mapper.Map<Language>(languageDto);
                                   _mangerRepo.LanguageRepo.Add(Language);
                                   _mangerRepo.save();
                                   return new HttpResponse<int>(){Status=true};
                        }

                       
                        public async Task<HttpResponse<LanguageDto>> GetLanguage(string Language)
                        {
                                   var LanguageDb= await _mangerRepo.LanguageRepo.GetLanguage(Language);
                                    var LanguageDto=_mapper.Map< LanguageDto>(LanguageDb);
                                    return new HttpResponse<LanguageDto>{Data= LanguageDto};

                        }
                         public async Task<HttpResponse<LanguageDto>> GetLanguageId(Guid Id)
                        {
                                   var LanguageDb= await _mangerRepo.LanguageRepo.GetLanguageId(Id);
                                    var LanguageDto=_mapper.Map< LanguageDto>(LanguageDb);
                                    return new HttpResponse<LanguageDto>{Data= LanguageDto};

                        }
                        public async Task< HttpResponse<List< LanguageDto>>>GetLanguageies()
                        {
                                    var languages = await _mangerRepo.LanguageRepo.GetLanguageies();
                                     var LanguageDto=_mapper.Map<List< LanguageDto>>(languages);
                                    return new HttpResponse<List< LanguageDto>>{Data= LanguageDto.ToList()};
                        }
                        //////////////currency
                        public Task<HttpResponse<int>> addAsyncCurrency(addCurrencyDto languageDto)
                        {
                                    throw new NotImplementedException();
                        }
                         public HttpResponse<int> addCurrency(addCurrencyDto currencyDto)
                        {
                                    var currency=_mapper.Map<Currency>(currencyDto);
                                    _mangerRepo.CurrencyRepo.Add(currency);
                                    _mangerRepo.save();
                                    return new HttpResponse<int>{Data=1};
                        }
                         public async Task<HttpResponse<List<CurrencyDto>>> GetCurrencies()
                        {
                                   var currency=await _mangerRepo.CurrencyRepo.GetCurrencies();
                                   var currenciesDto=_mapper.Map<List<CurrencyDto>>(currency);
                                   return new HttpResponse<List<CurrencyDto>>{Data=currenciesDto};
                        }

                        public Task<HttpResponse<CurrencyDto>> GetCurrency(string Language)
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<HttpResponse<CurrencyDto>> GetCurrency(Guid Language)
                        {
                                    throw new NotImplementedException();
                        }

            }
            
}