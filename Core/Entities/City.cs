using System;
using Core.Entity.Comman;
namespace Core.Entity
{
    public class City:BaseNameEntity
    {
        public Guid CounteryId { get; set; }
        public Countery Countery { get; set; }
    }
}