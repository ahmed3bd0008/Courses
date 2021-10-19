using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
namespace Repository.Implementation
{
    public class SkillRepo:GenericRepo<Skill>,ISkillRepo
    {
                        private readonly DapperContext _dapperContext;

                        public SkillRepo(AppDbContext appDbContext,DapperContext dapperContext) :base(appDbContext)
        {
            _dapperContext=dapperContext;
        }

                        public async Task<Skill> GetSkillId(Guid id)
                        {
                                  var query="SELECT * FROM Skills where Id=@Id ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Skill= await Connection.QuerySingleOrDefaultAsync<Skill>(query,new {Id=id});
                                              return Skill;
                                  }
                        }

                        public async Task<IEnumerable<Skill>> GetSkills()
                        {
                                  var query="SELECT * FROM Skills  ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Skills= await Connection.QueryAsync<Skill>(query);
                                              return Skills;
                                  }
                        }
                        public async Task<IEnumerable<Skill>> GetSkills(string skillName)
                        {
                                   var query="SELECT * FROM Skills  WHERE Name LIKE @Name +'%' ";
                                  using(var Connection=_dapperContext.CreateConnection())
                                  {
                                              var Skills= await Connection.QueryAsync<Skill>(query,new {Name=skillName});
                                              return Skills;
                                  }
                        }
            }
}