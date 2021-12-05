using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity.Comman;

namespace Repository.Interfacies
{
    public interface IGenericRepo<T> where T:BaseEntity
    {
        void Add(T Model);
        void Delete(T Model);
        void Update(T Model);
        Task AddAsync(T Model);
        List<T>GetAll();
    }
}