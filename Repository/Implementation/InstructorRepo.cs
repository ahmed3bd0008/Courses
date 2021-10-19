using Core.Entity;
using Repository.Interfacies;
using Repository.Context;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Repository.Implementation
{
    public class InstructorRepo:GenericRepo<Instructor>,IInstructorRepo
    {
        public InstructorRepo(AppDbContext appDbContext,DapperContext dapperContext):base(appDbContext)
        {
            
        }

                        public Task<Instructor> GetInstructorId(Guid id)
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Instructor>> GetInstructors()
                        {
                                    throw new NotImplementedException();
                        }

                        public Task<IEnumerable<Instructor>> GetInstructors(string skillName)
                        {
                                    throw new NotImplementedException();
                        }
            }
}