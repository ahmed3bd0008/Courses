using Core.Entity.Course;
using Repository.Context;
using Repository.Interfacies;

namespace Repository.Implementation
{
    public class coursetrackRepo:GenericRepo<courseTrack>,IcoursetrackRepo
    {
        private readonly DapperContext _dapperContext;
        private readonly AppDbContext _context;
        public coursetrackRepo(AppDbContext context,DapperContext dapperContext):base(context)
        {
            _context=context;
            _dapperContext=dapperContext;
        }
        
    }
}