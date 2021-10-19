using  Core.Entity.Course;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Dapper;
namespace Repository.Implementation
{
    public class CourseStatuseRepo:GenericRepo<CourseStatus>,ICourseStatuseRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CourseStatuseRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
                        {  
                            _dapperContext=dapperContext;
                        }
                        public async Task<IEnumerable<CourseStatus>> GetCourseStatus()
                        {
                               var query="SELECT * FROM CourseStatuses";
                               using(var connection=_dapperContext.CreateConnection())
                               {
                                 var courstype= await  connection.QueryAsync<CourseStatus>(query);
                                  return courstype;
                               }
                        }

                        public async Task<IEnumerable<CourseStatus>> GetCourseStatus(string courseStatus)
            {
                    var query="SELECT * FROM CourseStatuses WHERE Name like @Name +'%' ";
                    using(var connection=_dapperContext.CreateConnection())
                    {
                        var courseTypes=await connection .QueryAsync<CourseStatus>(query,new {Name=courseStatus});
                        return courseTypes;
                    }
            }

        public async Task<CourseStatus> GetCourseStatusId(Guid id)
        {
                                var query="SELECT * FROM CourseStatuses WHERE id=@Id  ";
                    using(var connection=_dapperContext.CreateConnection())
                    {
                        var courseType=await connection .QueryFirstOrDefaultAsync<CourseStatus>(query,new {Id=id});
                        return courseType;
                    }
        }                 
    }
}