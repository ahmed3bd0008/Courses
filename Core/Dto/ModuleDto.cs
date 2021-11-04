using System;
namespace Core.Dto
{
    public class ModuleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class AddModuleDto
    {
        public string Name { get; set; }
    }
}