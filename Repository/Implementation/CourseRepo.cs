using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entity.Course;
using Repository.Context;
using Repository.Interfacies;
using Dapper;
namespace Repository.Implementation
{
    public class CourseRepo:GenericRepo<Course>,ICourseRepo
    {
                        private readonly DapperContext _dapperContext;

                        public CourseRepo(AppDbContext context,DapperContext dapperContext):base(context)
        {
            _dapperContext=dapperContext;
        }

                        public async Task<Course> GetCourse(Guid Id)
                        {
                                var query="SELECT * FROM COURSE WHERE id = @Id";
                                using(var connection=_dapperContext.CreateConnection())
                                {
                                    var Course=await connection.QuerySingleOrDefaultAsync<Course>(query,new {Id}) ;
                                    return Course;
                                }
                        }

                        public Task<IEnumerable<Course>> GetCourses()
                        {
                                   var query="SELECT * FROM course";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                       var courses=connection.QueryAsync<Course>(query);
                                       return courses;
                                   }
                        }

                        public Task<IEnumerable<Course>> GetCourses(Expression<Func<Course, bool>> expression)
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Course>> GetCoursespres()
                        {
                                   var query="SELECT id, Name FROM Course";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                       var couse=connection.QueryAsync<Course>(query);
                                       return couse;
                                   }
                        }

                        public Task<IEnumerable<Course>> GetCoursespres(string courseName)
                        {
                                   var query="SELECT id, Name FROM Course where Name like @Name +'%' ";
                                   using(var connection=_dapperContext.CreateConnection())
                                   {
                                       var couse=connection.QueryAsync<Course>(query);
                                       return couse;
                                   }
                        }
            }
}