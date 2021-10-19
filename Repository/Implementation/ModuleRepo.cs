using Core.Entity;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Repository.Implementation
{
    public class ModuleRepo:GenericRepo<Module>,IModuleRepo
    {
        public ModuleRepo(AppDbContext AppDbContext ,DapperContext dapperContext):base(AppDbContext)
        {
            
        }

                        public Task<Module> GetModuleId(Guid id)
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Module>> GetModules()
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Module>> GetModules(string moduleName)
                        {
                                    throw new NotImplementedException();
                        }
            }
}