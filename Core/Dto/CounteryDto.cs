using System;

namespace Core.Dto
{
    public class CounteryDto
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public CityDto Cities { get; set; }
    }
     public class AddCountryDto
    {
        public string  Name { get; set; }
    }
}