using System;
using System.ComponentModel.DataAnnotations;
namespace Core.Entity.Comman
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}