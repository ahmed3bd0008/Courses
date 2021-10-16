using System;
namespace Core.Entity.Comman
{
    public class BaseAuditEntity:BaseNameEntity
    {
        public Guid EnterBy { get; set; }
        public DateTime EnterDate { get; set; }
        public Guid ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}