using System.Threading.Tasks;
using Repository.Context;
using Repository.Interfacies;
using Repository.Implementation;
namespace Repository.Implementation
{
            public class MangerRepo : IMangerRepo
            {
                        public MangerRepo(AppDbContext context,DapperContext dapperContext)
                        {
                            _context=context;
                            _dapperContext=dapperContext;
                        }
                        private  ILanguageRepo _languageRepo;
                        private  ICurrencyRepo _currencyRepo;
                        private  ICourseLevelRepo _courseLevelRepo;
                        private  ICourseRepo _courseRepo;
                        private  ICourseTypeRepo _courseTypeRepo;
                        private  ICourseStatuseRepo _courseStatusRepo;
                        private readonly AppDbContext _context;
                        private readonly DapperContext _dapperContext;
                         private  ISkillRepo _skillRepo;
                        private  IModuleRepo _ModuleRepo;
                        private  IInstructorRepo _instructorRepo;
                        private  ICourseCategoryRepo _courseCategoryRepo;
                        private  ICityRepo _cityRepo;
                        private  ICounteryRepo _counteryRepo;
                        public DapperContext dapperContext{get{return _dapperContext;}}
                        public ILanguageRepo LanguageRepo 
                        {
                                    get{
                                                if(_languageRepo==null)
                                                            _languageRepo=new LanguageRepo(_context,_dapperContext);
                                                return _languageRepo;
                                    }
                        }
                         public ICurrencyRepo CurrencyRepo 
                        {
                                    get{
                                                if(_currencyRepo==null)
                                                            _currencyRepo=new  CurrencyRepo(_context,_dapperContext);
                                                return _currencyRepo;
                                    }
                        }
                         public ICourseLevelRepo CourseLevelRepo 
                        {
                                    get{
                                                if(_courseLevelRepo==null)
                                                            _courseLevelRepo=new  CourseLevelRepo(_context,_dapperContext);
                                                return _courseLevelRepo;
                                    }
                        }
                        public ICourseRepo CourseRepo {
                            get{
                                if (_courseRepo==null)
                                    _courseRepo=new CourseRepo(context:_context,dapperContext: _dapperContext);
                                return _courseRepo;
                            }
                        }
                        public ICourseStatuseRepo CourseStatuseRepo 
                        {
                            get{
                                if (_courseStatusRepo==null)
                                    _courseStatusRepo=new CourseStatuseRepo(appDbContext:_context,dapperContext: _dapperContext);
                                return _courseStatusRepo;
                            }
                        }
                        public ICourseTypeRepo CourseTypeRepo 
                        {
                            get{
                                if (_courseTypeRepo==null)
                                    _courseTypeRepo=new CourseTypeRepo(appDbContext:_context,dapperContext: _dapperContext);
                                return _courseTypeRepo;
                            }
                        }
                        public IInstructorRepo InstructorRepo
                        {
                            get{
                                if(_instructorRepo==null)
                                    _instructorRepo=new InstructorRepo(_context,_dapperContext);
                                return _instructorRepo;
                            }
                        }
                        public IModuleRepo ModuleRepo 
                        {
                            get{
                                if(_ModuleRepo==null)
                                    _ModuleRepo=new ModuleRepo(_context,_dapperContext);
                                return _ModuleRepo;
                            }
                        }
                        public ISkillRepo SkillRepo 
                        {
                              get{
                                if(_skillRepo==null)
                                    _skillRepo=new SkillRepo(_context,_dapperContext);
                                return _skillRepo;
                            }
                        }

                        public ICourseCategoryRepo CourseCategoryRepo 
                        {
                            get{
                                if(_courseCategoryRepo==null)
                                    _courseCategoryRepo=new CourseCategoryRepo(_context,_dapperContext);
                                    return _courseCategoryRepo;
                            }
                        }

                        public ICounteryRepo CounteryRepo
                        {
                            get{
                                if(_counteryRepo==null)
                                    _counteryRepo=new CounteryRepo(_context,_dapperContext);
                                return _counteryRepo;
                            }
                        }

                        public ICityRepo CityRepo {
                             get{
                                if(_cityRepo==null)
                                    _cityRepo=new CityRepo(_context,_dapperContext);
                                return _cityRepo;
                            }
                        }

                        public int save()
                        {
                               return     _context.SaveChanges();
                        }
                        public async Task<int> saveAsync()
                        {
                                    return await _context.SaveChangesAsync();
                        }
            }
}