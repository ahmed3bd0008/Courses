using System;
namespace Core.Entity
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicUrl { get; set; }
        public Guid AppUserId { get; set; }
    }
}