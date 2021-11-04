using Core.Entity;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Dapper;
namespace Repository.Implementation
{
    public class InstructorRepo:GenericRepo<Instructor>,IInstructorRepo
    {
                        private readonly DapperContext _dapperContext;

                        public InstructorRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
                            {
                                _dapperContext=dapperContext;
                            }

                        public async Task<Instructor> GetInstructorId(Guid id)
                        {
                                      var query="SELECT * FROM Instructors where Id=@Id ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var instructor= await Connection.QuerySingleOrDefaultAsync<Instructor>(query,new {Id=id});
                                              return instructor;
                                  }
                        }

                        public async Task<IEnumerable<Instructor>> GetInstructors()
                        {
                                    var query="SELECT * FROM Instructors  ";
                                     using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var instructor= await Connection.QueryAsync<Instructor>(query);
                                              return instructor;
                                  }
                        }

                        public async
                         Task<IEnumerable<Instructor>> GetInstructors(string skillName)
                        {                                         
                             var query="SELECT * FROM Instructors WHERE Name LIKE @Name +'%'";
                                     using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var instructor= await Connection.QueryAsync<Instructor>(query,new{Name=skillName});
                                              return instructor;
                                  }
                        }
            }
}