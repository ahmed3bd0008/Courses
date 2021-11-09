using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
using Core.Paging;
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

                        public async Task<PagingList<Countery>> GetCounteryOrderByName(RequestCounteryPrameter counteryPrameter)
                        {
                                   var OrderString=counteryPrameter.SortQueue=="DESC"?"DESC":"ASC";
                                   var Query=$"SELECT * FROM Counteries ORDER BY Name {OrderString} ";
                                     using(var connection=_dapperContext.CreateConnection())
                                   {
                                               var counteries=await connection.QueryAsync<Countery>(Query);
                                               return  PagingList<Countery>.ToPageList(Source:counteries.AsList(),PageIndex:counteryPrameter.PageNumber,PageSize:counteryPrameter.PageSize);
                                   }

                        }

                        public async Task<List<City>> GetCounteryWithCitIes()
                        {
                                  var query="SELECT * FROM Counteries JOIN Cities on Cities.CounteryId=Counteries.Id";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                    
                                               var Cities=await connection.QueryAsync<City,Countery,City>(query,(city,countery)=>{city.Countery=countery;return city;},splitOn:"CounteryId");
                                               return Cities.AsList();
                                   }
                        }
            }
}