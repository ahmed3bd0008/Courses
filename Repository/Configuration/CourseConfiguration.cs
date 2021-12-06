using Microsoft.EntityFrameworkCore;
using Core.Entity.Course;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
            public class CourseConfiguration : IEntityTypeConfiguration<Course>
            {
                        public void Configure(EntityTypeBuilder<Course> builder)
                        {
                                    builder.HasKey(k=>k.Id);
                                    builder.Property(p=>p.Name).IsRequired();
                                    builder.Property(p=>p.CourseRefrance).IsRequired();
                                    builder.HasIndex(i=>i.CourseRefrance).IsUnique();
                                    builder.HasOne(d=>d.CourseLevel).WithMany().HasForeignKey(f=>f.courseLevelId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.language).WithMany(m=>m.Course).HasForeignKey(f=>f.LanguageId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.currency).WithMany().HasForeignKey(f=>f.CurrencyId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.CourseStatus).WithMany().HasForeignKey(f=>f.CourseStatusId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.CourseCategory).WithMany(m=>m.Courses).HasForeignKey(fk=>fk.CourseCategoryId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.CourseType).WithMany().HasForeignKey(fk=>fk.CourseTypeId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasMany(d=>d.CourseInstructors).WithOne(m=>m.Course).HasForeignKey(fk=>fk.CourseId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasMany(d=>d.CourseModules).WithOne(m=>m.Course).HasForeignKey(fk=>fk.CourseId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasMany(d=>d.CourseGainSkills).WithOne(m=>m.Course).HasForeignKey(fk=>fk.CourseId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasMany(d=>d.CourseRequiredSkills).WithOne(m=>m.Course).HasForeignKey(fk=>fk.CourseId).OnDelete(DeleteBehavior.Cascade); 
                                    builder.HasOne(d=>d.CourseTrack).WithMany(m=>m.Courses).HasForeignKey(fk=>fk.CourseTrackId).HasConstraintName("FKcourseTrackId") ;        
                        }
            }
}