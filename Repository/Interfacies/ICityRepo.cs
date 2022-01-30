using Core.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interfacies
{
    public interface ICityRepo:IGenericRepo<City>
    {
        public Task<City> GetCity(Guid gityId);
        public Task<List<City>> GetCity();
        public Task<List<City>> GetCity(string CityName);
        public Task<List<City>> GetcountryCitiesByName(string counteryName);
        public Task<List<City>> GetcountryCitiesById(Guid CounteryId);

        public City findCitycity(string CityName,Guid counteryId);
         public  Task<List< City>>GetCounteriesFull();
        public Task<City> findCitycityAsync(string CityName,Guid counteryId);
    }
}