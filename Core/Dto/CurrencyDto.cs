using System;

namespace Core.Dto
{
    public class CurrencyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class addCurrencyDto
    {
        public string Name { get; set; }
    }
}