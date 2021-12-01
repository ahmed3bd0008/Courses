using System;
using Core.Entity.Comman;
using Core.Entity.User;

namespace Core.Entity
{
    public class City:BaseNameEntity
    {
        public Guid CounteryId { get; set; }
        public Countery Countery { get; set; }
        public AppUser AppUser { get; set; }
    }
}