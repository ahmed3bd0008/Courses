using Core.Entity;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Dapper;
namespace Repository.Implementation
{
    public class ModuleRepo:GenericRepo<Module>,IModuleRepo
    {
                        private readonly DapperContext _dapperContext;

                        public ModuleRepo(AppDbContext AppDbContext ,DapperContext dapperContext):base(AppDbContext)
        {
            _dapperContext=dapperContext;
        }

                        public async Task<Module> GetModuleId(Guid id)
                        {
                                  var query="SELECT * FROM Modules where Id=@Id ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Module= await Connection.QuerySingleOrDefaultAsync<Module>(query,new {Id=id});
                                              return Module;
                                  }
                        }

                        public async Task<IEnumerable<Module>> GetModules()
                        {
                                   var query="SELECT * FROM Modules  ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Modules= await Connection.QueryAsync<Module>(query);
                                              return Modules;
                                  }
                        }

                        public async Task<IEnumerable<Module>> GetModules(string moduleName)
                        {
                                     var query="SELECT * FROM Modules WHERE Name LIKE @Name +'%'  ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Modules= await Connection.QueryAsync<Module>(query,new {Name=moduleName});
                                              return Modules;
                                  }
                        }
            }
}