using  Core.Entity.Course;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Dapper;
namespace Repository.Implementation
{
    public class CourseCategoryRepo:GenericRepo<CourseCategory>,ICourseCategoryRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CourseCategoryRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
         {  
             _dapperContext=dapperContext;
         }
         public async Task<IEnumerable<CourseCategory>> GetCategory()
                        {
                               var query="SELECT * FROM CourseCategories";
                               using(var connection=_dapperContext.CreateConnection())
                               {
                                 var courseCategory= await  connection.QueryAsync<CourseCategory>(query);
                                  return courseCategory;
                               }
                        }

        public async Task<IEnumerable<CourseCategory>> GetCategory(string courseCategory)
            {
                    var query="SELECT * FROM CourseCategory WHERE Name like @Name +'%' ";
                    using(var connection=_dapperContext.CreateConnection())
                    {
                        var courseCategoryDb=await connection .QueryAsync<CourseCategory>(query,new {Name=courseCategory});
                        return courseCategoryDb;
                    }
            }

        public async Task<CourseCategory> GetCategoryId(Guid id)
        {
                                var query="SELECT * FROM CourseCategory WHERE id=@Id  ";
                    using(var connection=_dapperContext.CreateConnection())
                    {
                        var courseCategoryDb=await connection .QueryFirstOrDefaultAsync<CourseCategory>(query,new {Id=id});
                        return courseCategoryDb;
                    }
        }
    }
}