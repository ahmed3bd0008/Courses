using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Repository.Interfacies
{
    public interface IInstructorRepo:IGenericRepo<Instructor>
    {
          Task< IEnumerable<Instructor>> GetInstructors();
           Task <IEnumerable<Instructor>> GetInstructors(string skillName);
           Task<Instructor> GetInstructorId(System.Guid id);
    }
}