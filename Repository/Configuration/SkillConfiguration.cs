using Microsoft.EntityFrameworkCore;
using Core.Entity.Course;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entity;

namespace Repository.Configuration
{
            public class SkillConfiguration : IEntityTypeConfiguration<Skill>
            {
                        public void Configure(EntityTypeBuilder<Skill> builder)
                        {
                                    builder.HasKey(k=>k.Id);
                                    builder.HasMany(m=>m.CourseRequiredSkills).WithOne(o=>o.Skill).HasForeignKey( fk=>fk.SkillId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasMany(m=>m.CourseGainSkills).WithOne(o=>o.Skill).HasForeignKey( fk=>fk.SkillId).OnDelete(DeleteBehavior.Cascade);
                        }
            }
}