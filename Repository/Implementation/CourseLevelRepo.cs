using Core.Entity.Course;
using Repository.Interfacies;
using Repository.Context;
namespace Repository.Implementation
{
    public class CourseLevelRepo:GenericRepo<Course>,ICourseLevelRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CourseLevelRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
        {
            _dapperContext=dapperContext;
        }
    }
}