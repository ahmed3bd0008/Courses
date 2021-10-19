using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
namespace Repository.Interfacies
{
    public interface ISkillRepo:IGenericRepo<Skill>
    {
          Task< IEnumerable<Skill>> GetSkills();
           Task <IEnumerable<Skill>> GetSkills(string skillName);
           Task<Skill> GetSkillId(Guid id);
    }
}