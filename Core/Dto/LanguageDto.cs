using System;

namespace Core.Dto
{
    public class LanguageDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
     public class AddLanguageDto
    {
        public string Name { get; set; }
    }
}