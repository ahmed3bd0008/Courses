using System;
using System.Collections.Generic;

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
    public class CityCounteryDto
    {
        public List< CityDto> Cities { get; set; }
        public CounteryDto Counteries { get; set; }
    }
}