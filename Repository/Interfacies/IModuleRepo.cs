using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Repository.Interfacies
{
    public interface IModuleRepo:IGenericRepo<Module>
    {
          Task< IEnumerable<Module>> GetModules();
           Task <IEnumerable<Module>> GetModules(string moduleName);
           Task<Module> GetModuleId(Guid id);
    }
}