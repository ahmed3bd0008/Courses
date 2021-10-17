using Core.Entity.Course;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using Dapper;

namespace Repository.Implementation
{
    public class CourseLevelRepo:GenericRepo<CourseLevel>,ICourseLevelRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CourseLevelRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
        {
            _dapperContext=dapperContext;
        }
          public async Task<IEnumerable<CourseLevel>> GetCourseLevel()
                        {
                                var query="SELECT id, Name FROM CourseLevels";
                                 using(  var connection=_dapperContext.CreateConnection())
                                 {
                                        var currency=await connection.QueryAsync<CourseLevel>(query);
                                        return currency;
                                 }
                                    
                        }
        
    }
}