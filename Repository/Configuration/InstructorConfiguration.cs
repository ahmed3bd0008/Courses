using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entity;
namespace Repository.Configuration
{
            public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
            {
                        public void Configure(EntityTypeBuilder<Instructor> builder)
                        {
                                    builder.HasKey(k=>k.Id);
                                    builder.HasMany(m=>m.CourseInstructor).WithOne(o=>o.Instructor).
                                                HasForeignKey(fk=>fk.InstructorId).OnDelete(DeleteBehavior.Cascade);
                                   
                        }
            }
}