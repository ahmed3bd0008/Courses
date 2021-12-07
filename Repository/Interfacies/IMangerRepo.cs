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
         public ICourseCategoryRepo CourseCategoryRepo { get;  }
         public ICourseTypeRepo CourseTypeRepo { get;  }
         public ICourseRepo CourseRepo { get;  }
         public IInstructorRepo InstructorRepo { get;  }
         public IModuleRepo ModuleRepo { get;  }
         public ISkillRepo SkillRepo { get;  }
         public IcoursetrackRepo CourseTrackRepo { get;  }
         public ICounteryRepo CounteryRepo { get;  }
         public ICityRepo CityRepo { get;  }
        public DapperContext dapperContext{get;}

         int save();
         Task<int>saveAsync();
    }
}