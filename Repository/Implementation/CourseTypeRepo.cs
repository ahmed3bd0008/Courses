using  Core.Entity.Course;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Dapper;
namespace Repository.Implementation
{

    public class CourseTypeRepo:GenericRepo<CourseType>,ICourseTypeRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CourseTypeRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
         {  
             _dapperContext=dapperContext;
         }
         public async Task<IEnumerable<CourseType>> GetCourseType()
                        {
                               var query="SELECT * FROM CourseTypes";
                               using(var connection=_dapperContext.CreateConnection())
                               {
                                 var courstype= await  connection.QueryAsync<CourseType>(query);
                                  return courstype;
                               }
                        }

                        public async Task<IEnumerable<CourseType>> GetCourseType(string courseType)
            {
                    var query="SELECT * FROM CourseTypes WHERE Name like @Name +'%' ";
                    using(var connection=_dapperContext.CreateConnection())
                    {
                        var courseTypes=await connection .QueryAsync<CourseType>(query,new {Name=courseType});
                        return courseTypes;
                    }
            }

        public async Task<CourseType> GetCourseTypeId(Guid id)
        {
                                var query="SELECT * FROM CourseTypes WHERE id=@Id  ";
                    using(var connection=_dapperContext.CreateConnection())
                    {
                        var courseType=await connection .QueryFirstOrDefaultAsync<CourseType>(query,new {Id=id});
                        return courseType;
                    }
        }

                      
            }
}