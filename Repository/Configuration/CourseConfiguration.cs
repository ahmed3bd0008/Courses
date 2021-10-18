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
                                    builder.HasOne(d=>d.CourseLevel).WithMany().HasForeignKey(f=>f.courseLevelId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.language).WithMany().HasForeignKey(f=>f.LanguageId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.currency).WithMany().HasForeignKey(f=>f.CurrencyId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.CourseStatus).WithMany().HasForeignKey(f=>f.CourseStatusId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.currency).WithMany().HasForeignKey(f=>f.CurrencyId).OnDelete(DeleteBehavior.Cascade);
                                    builder.HasOne(d=>d.CourseCategory).WithMany(m=>m.Courses).HasForeignKey(fk=>fk.CourseCategoryId).OnDelete(DeleteBehavior.Cascade);
                        }
            }
}