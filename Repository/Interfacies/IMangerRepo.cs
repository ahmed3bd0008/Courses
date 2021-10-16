using System.Threading.Tasks;
using Repository.Context;

namespace Repository.Interfacies
{
    public interface IMangerRepo
    {
         public ILanguageRepo LanguageRepo { get;  }
        public DapperContext dapperContext{get;}

         int save();
         Task<int>saveAsync();
    }
}