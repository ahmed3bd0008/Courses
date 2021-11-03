using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
namespace Repository.Implementation
{
    public class CounteryRepo:GenericRepo<Countery> ,ICounteryRepo
    {
                        private readonly DapperContext _dapperContext;
                        public CounteryRepo(AppDbContext context,DapperContext dapperContext):base(context)
                        {
                                    _dapperContext=dapperContext;
                        }
                        public async Task<Countery> GetCountery(Guid CounterId)
                        {
                                     var query="SELECT * FROM Counteries WHERE Id=@Id ";
                                      using(var connection=_dapperContext.CreateConnection())
                                      {
                                                  var countery=await connection.QuerySingleOrDefaultAsync<Countery>(query,new{Id=CounterId});
                                                  return countery;
                                      }
                        }
                        public async Task<List<Countery>> GetCountery()
                        {
                                    var query="SELECT * FROM Counteries";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                               var counteries=await connection.QueryAsync<Countery>(query);
                                               return counteries.AsList();
                                   }
                        }
                        public async Task<List<Countery>> GetCountery(string CounteryName)
                        {
                                    var query="SELECT * FROM Counteries WHERE @Name +'%'";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                               var Cities=await connection.QueryAsync<Countery>(query,new {Name=CounteryName});
                                               return Cities.AsList();
                                   }
                        }                    
    }
}