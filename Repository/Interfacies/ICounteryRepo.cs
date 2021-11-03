using Core.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interfacies
{
    public interface ICounteryRepo:IGenericRepo<Countery>
    {
        public Task<Countery> GetCountery(Guid CounterId);
        public Task<List<Countery>> GetCountery();
        public Task<List<Countery>> GetCountery(string CounteryId);
    }
}