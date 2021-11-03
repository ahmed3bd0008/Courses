using Microsoft.EntityFrameworkCore;
using Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
            public class CounteryConfiguration : IEntityTypeConfiguration<Countery>
            {
                        public void Configure(EntityTypeBuilder<Countery> builder)
                        {
                                    builder.HasMany(m=>m.Cities).
                                    WithOne(o=>o.Countery).
                                    HasForeignKey(fk=>fk.CounteryId).
                                    OnDelete(DeleteBehavior.Cascade);
                        }
            }
}