using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Dapper;
using Repository.Context;
using Repository.Interfacies;

namespace Repository.Implementation
{
    public class LanguageRepo:GenericRepo<Language>,ILanguageRepo
    {
                        private readonly DapperContext _dapperContext;
                        private readonly AppDbContext _context;

                        public LanguageRepo(AppDbContext context,DapperContext dapperContext):base(context)
                        {
                            _dapperContext=dapperContext;
                            _context=context;
                        }

                        public async Task<Language> GetLanguage(string language)
                        {

                            
                                    var query="select id, name from language where name LIKE @Language";
                                    using (var connection = _dapperContext.CreateConnection())
                                    {
                                        var languageDb= await connection.QueryFirstOrDefaultAsync<Language>(query,new{language});
                                        return languageDb;
                                    }
                        }

                        public async Task<Language> GetLanguageId(Guid id)
                        {
                                    var query="select id, name from language where id = @Id";
                                    using (var connection = _dapperContext.CreateConnection())
                                    {
                                        var languageDb= await connection.QueryFirstOrDefaultAsync<Language>(query,new{id});
                                        return languageDb;
                                    }
                        }


                        public async Task< IEnumerable<Language>> GetLanguageies()
                        {
                            var query = "SELECT * FROM Language";
                             using (var connection = _dapperContext.CreateConnection())
                                {
                                    var languages = await connection.QueryAsync<Language>(query);
                                    return languages;
                                }
                        }

                        
            }
}