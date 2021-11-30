using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
using System.Linq;

namespace Repository.Implementation
{
    public class CityRepo:GenericRepo<City> ,ICityRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CityRepo(AppDbContext context,DapperContext dapperContext):base(context)
                        {
                                    _dapperContext=dapperContext;
                        }

        public  City findCitycity(string CityName,Guid counteryId)
        {
            var query="SELECT * FROM Cities WHERE Name=@name and counteryId=@counteryId";
            using(var connection=_dapperContext.CreateConnection())
            {
                var city=  connection.QueryFirstOrDefault<City>(query,new {name=CityName,counteryId=counteryId});
                return city;
            }
        }

        public async Task<City> findCitycityAsync(string CityName,Guid counteryId)
        {
             var query="SELECT * FROM Cities WHERE Name=@name and counteryId=@counteryId  ";
            using(var connection=_dapperContext.CreateConnection())
            {
                var city=await  connection.QueryFirstOrDefaultAsync<City>(query,new {name=CityName,counteryId=counteryId});
                return city;
            }
        }

        public async Task<City> GetCity(Guid cityId)
                        {
                                      var query="SELECT * FROM Cities WHERE Id=@Id ";
                                      using(var connection=_dapperContext.CreateConnection())
                                      {
                                                  var City=await connection.QuerySingleOrDefaultAsync<City>(query,new{Id=cityId});
                                                  return City;
                                      }
                        }

                        public      async Task<List<City>> GetCity()
                        {
                                   var query="SELECT * FROM Cities";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                               var Cities=await connection.QueryAsync<City>(query);
                                               return Cities.AsList();
                                   }
                        }

                        public async Task<List<City>> GetCity(string CityName)
                        {
                                   var query="SELECT * FROM Cities WHERE @Name +'%'";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                               var Cities=await connection.QueryAsync<City>(query,new {Name=CityName});
                                               return Cities.AsList();
                                   }
                        }
            
        //      public async Task<List< City>>GetCounteriesFull()
        //          {
        //         var query= "SELECT * FROM  Cities JOIN Counteries ON Cities.CounteryId =Counteries.Id ";
        //         using(var connection=_dapperContext.CreateConnection())
        //         {
        //          {
        //         var counteryDict = new Dictionary<Guid, City>();
        //         var counteryDict3 = new Dictionary<Guid, City>();
        //         var Counteries = await connection.QueryAsync<City, Countery, City>(
        //             query, (city, countery) =>
        //             {
        //                 if (!counteryDict.TryGetValue(city.Id, out var currentCompany))
        //                 {
        //                     currentCompany = city;
        //                     counteryDict.Add(currentCompany.Id, currentCompany);        
        //                     city.Countery=new Countery();
        //                 }
        //                 currentCompany.Countery=countery;
        //                 return currentCompany;
        //             }
        // );
        //           return Counteries.Distinct().ToList();
    
        //         }
        // }
        // }
              public async Task<List< City>>GetCounteriesFull()
                 {
                var query= "SELECT * FROM  Cities JOIN Counteries ON Cities.CounteryId =Counteries.Id ";
                using(var connection=_dapperContext.CreateConnection())
                {
                 {
                var Counteries = await connection.QueryAsync<City, Countery, City>(
                    query, (city, countery) =>
                    {
                        city.Countery=countery;
                        return city;
                    }
        );
                  return Counteries.Distinct().ToList();
    
                }
        }
        }
                
    }
}
                 