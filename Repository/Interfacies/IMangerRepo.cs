using System.Threading.Tasks;
using Repository.Context;

namespace Repository.Interfacies
{
    public interface IMangerRepo
    {
         public ILanguageRepo LanguageRepo { get;  }
         public ICurrencyRepo CurrencyRepo { get;  }
         public ICourseLevelRepo CourseLevelRepo { get;  }
         public ICourseStatuseRepo CourseStatuseRepo { get;  }
         public ICourseTypeRepo CourseTypeRepo { get;  }
         public ICourseRepo CourseRepo { get;  }
        public DapperContext dapperContext{get;}

         int save();
         Task<int>saveAsync();
    }
}