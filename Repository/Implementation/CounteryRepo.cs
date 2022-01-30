using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
using Core.Paging;
using System.Linq;

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

                        public async Task<IEnumerable<Countery>> GetCounteryOrderByName(RequestCounteryPrameter counteryPrameter)
                        {
                                   var OrderString=counteryPrameter.SortQueue=="DESC"?"DESC":"ASC";
                                   var Query=$"SELECT * FROM Counteries ORDER BY Name {OrderString} ";
                                     using(var connection=_dapperContext.CreateConnection())
                                   {
                                               var counteries=await connection.QueryAsync<Countery>(Query);
                                               return  counteries;
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

            //     public async Task<List< Countery>>GetCounteriesFull()
            //      {
            //                var query= "SELECT * FROM Counteries "+"select * from   Cities ";
            //                        using(var connection=_dapperContext.CreateConnection())
            //                        {
            //     try {

            //         var countery = await connection.QueryAsync<Countery, City, Countery>(query, (countery, city) => { countery.Cities = countery.Cities; return countery; }, splitOn: "Id");
            //         Console.WriteLine("drsd");
            //         return countery.AsList();
            //     }
            //     catch (Exception ex)
            //     {
            //         Console.WriteLine(ex.Message);
            //     }
            //                        }
            // return new List<Countery>();
            //             }
            // }
            
              public async Task<List< Countery>>GetCounteriesFull()
                 {
                var query= "SELECT * FROM Counteries JOIN Cities ON Counteries.Id=Cities.CounteryId ";
                using(var connection=_dapperContext.CreateConnection())
                {
                 {
                var counteryDict = new Dictionary<Guid, Countery>();
                var counteryDict3 = new Dictionary<Guid, Countery>();
                var Counteries = await connection.QueryAsync<Countery, City, Countery>(
                    query, (Countery, City) =>
                    {
                        if (!counteryDict.TryGetValue(Countery.Id, out var currentCountery))
                        {
                            currentCountery = Countery;
                            counteryDict.Add(currentCountery.Id, currentCountery);        
                            currentCountery.Cities=new List<City>();
                        }
                        currentCountery.Cities.Add(City);
                        return currentCountery;
                    }
        );
                  return Counteries.Distinct().ToList();
    
                 }
                }
                 }
    }
}

                                   
          
                        
            

