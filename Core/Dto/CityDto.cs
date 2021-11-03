using System;

namespace Core.Dto
{
    public class CityDto
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
    }
     public class AddCityDto
    {
        public string  Name { get; set; }
        public Guid CounteryId { get; set; }
    }
}