using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Repository.Interfacies
{
    public interface ILanguageRepo:IGenericRepo<Language>
    {
           Task< IEnumerable<Language>> GetLanguageies();
           Task<Language> GetLanguage(string language);
           Task<Language> GetLanguageId(Guid id);
    }
}