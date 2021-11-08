using Core.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Paging;
namespace Repository.Interfacies
{
    public interface ICounteryRepo:IGenericRepo<Countery>
    {
        public Task<Countery> GetCountery(Guid CounterId);
        public Task<List<Countery>> GetCountery();
        public Task<List<Countery>> GetCountery(string CounteryId);
        public Task<PagingList<Countery>> GetCounteryOrderByName(RequestCounteryPrameter counteryPrameter);
        public Task<List<City>> GetCounteryWithCitIes();
    }
}