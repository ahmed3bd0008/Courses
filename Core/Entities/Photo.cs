using System;
using Core.Entity.Comman;

namespace Core.Entity
{
    public class Photo:BaseEntity
    {
        public String Url { get; set; }
        public bool IsMain { get; set; }
        public string PubliId { get; set; }
        public Guid UserId { get; set; }
        public User.AppUser User { get; set; }
    }
}