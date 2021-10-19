using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Repository.Context;
using Repository.Interfacies;

namespace Repository.Implementation
{
    public class SkillRepo:GenericRepo<Skill>,ISkillRepo
    {
                        private readonly DapperContext _dapperContext;

                        public SkillRepo(AppDbContext appDbContext,DapperContext dapperContext) :base(appDbContext)
        {
            _dapperContext=dapperContext;
        }

                        public Task<Skill> GetSkillId(Guid id)
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Skill>> GetSkills()
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Skill>> GetSkills(string skillName)
                        {
                                    throw new NotImplementedException();
                        }
            }
}