using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entity;

namespace Repository.Configuration
{
            public class ModuleConfiguration : IEntityTypeConfiguration<Module>
            {
                        public void Configure(EntityTypeBuilder<Module> builder)
                        {
                                    builder.HasKey(k=>k.Id);
                                    builder.HasMany(m=>m.CourseModule).WithOne(o=>o.Module).HasForeignKey(fK=>fK.ModuleId).OnDelete(DeleteBehavior.Cascade);
                                  
                        }
            }
}