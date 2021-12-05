using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity.Comman;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interfacies;

namespace Repository.Implementation
{
            public class GenericRepo<T> : IGenericRepo<T> where T : BaseEntity
            {
                private readonly AppDbContext _context;
                        private readonly DbSet<T> _entity;

                        public GenericRepo(AppDbContext context)
                {
                    _context=context;
                    _entity=context.Set<T>();
                }
                        public void Add(T Model)
                        {
                                   _context.Add(Model);
                        }

                        public async Task AddAsync(T Model)
                        {
                                    await _entity.AddAsync(Model);
                        }

                        public void Delete(T Model)
                        {
                                    _entity.Remove(Model);
                        }

                        public void Update(T Model)
                        {
                                   _entity.Update(Model);
                        }
                        public List<T>GetAll()
                        {
                            return _entity.ToList();
                        }

            }
}