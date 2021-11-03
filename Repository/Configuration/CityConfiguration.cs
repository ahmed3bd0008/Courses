using Core.Entity;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
            public class CityConfiguration : IEntityTypeConfiguration<City>
            {
                        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<City> builder)
                        {
                                    builder.HasOne(op=>op.Countery).
                                                WithMany(m=>m.Cities).
                                                HasForeignKey(fk=>fk.CounteryId).
                                                OnDelete(DeleteBehavior.Cascade);
                        }
            }
}