using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
            public class LanguageConfiguration : IEntityTypeConfiguration<Language>
            {
                        public void Configure(EntityTypeBuilder<Language> builder)
                        {
                                    builder.HasMany(m=>m.Course)
                                    .WithOne(o=>o.language)
                                    .HasForeignKey(fk=>fk.LanguageId).
                                     OnDelete(DeleteBehavior.Cascade);
                        }
            }
}