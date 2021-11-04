using Core.Entity.Comman;
using System.Collections.Generic;
namespace Core.Entity
{
    public class Countery:BaseNameEntity
    {
        public ICollection<City> Cities { get; set; }
    }
}