using Core.Entity;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Repository.Implementation
{
    public class InstructorRepo:GenericRepo<Instructor>,IInstructorRepo
    {
                        private readonly object _dapperContext;

                        public InstructorRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
        {
            _dapperContext=_dapperContext;
        }

                        public Task<Instructor> GetInstructorId(Guid id)
                        {
                                      var query="SELECT * FROM Modules where Id=@Id ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Module= await Connection.QuerySingleOrDefaultAsync<Module>(query,new {Id=id});
                                              return Module;
                                  }
                        }

                        public Task<IEnumerable<Instructor>> GetInstructors()
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Instructor>> GetInstructors(string skillName)
                        {
                                    throw new NotImplementedException();
                        }
            }
}