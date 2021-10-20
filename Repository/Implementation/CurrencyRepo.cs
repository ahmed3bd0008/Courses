using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
using System.Collections.Generic;

namespace Repository.Implementation
{
    public class CurrencyRepo:GenericRepo<Currency>, ICurrencyRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CurrencyRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
        {
            _dapperContext=dapperContext;
        }

                        public async Task<IEnumerable<Currency>> GetCurrencies()
                        {
                                var query="SELECT id, Name FROM Currency";
                                using(  var connection=_dapperContext.CreateConnection())
                                 {
                                    
                                        var currency=await connection.QueryAsync<Currency>(query);
                                        return currency;
                                 }
                                    
                        }
                        public async Task<IEnumerable<Currency>> GetCurrencies(string Name)
                        {
                                var query="SELECT id, Name FROM Currency WHERE Name LIKE @Name +'%'";
                                using(  var connection=_dapperContext.CreateConnection())
                                 {
                                    
                                        var currency=await connection.QueryAsync<Currency>(query,new {Name});
                                        return currency;
                                 }
                        }
                        public async Task<Currency>GetCurrencyById(System.Guid Id)
                        {
                                var query="SELECT id, Name FROM Currency WHERE Id =@Id";
                                using(  var connection=_dapperContext.CreateConnection())
                                 {
                                        var currency=await connection.QuerySingleAsync<Currency>(query,new {Id});
                                        return currency;
                                 }
                        }
            }
}