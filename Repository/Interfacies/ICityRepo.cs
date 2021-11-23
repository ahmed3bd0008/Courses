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
        public City findCitycity(string CityName,Guid counteryId);
        public Task<City> findCitycityAsync(string CityName,Guid counteryId);
    }
}