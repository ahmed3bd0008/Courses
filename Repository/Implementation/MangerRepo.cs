using System.Threading.Tasks;
using Repository.Context;
using Repository.Interfacies;
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
                        private readonly AppDbContext _context;
                        private readonly DapperContext _dapperContext;
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