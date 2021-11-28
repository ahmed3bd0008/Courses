using System;
using System.Collections.Generic;

namespace Core.Dto
{
    public class CounteryDto
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
    }
     public class AddCountryDto
    {
        public string  Name { get; set; }
    }
      public class counteryCitiesDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<CityDto> Cities { get; set; }
    }
}