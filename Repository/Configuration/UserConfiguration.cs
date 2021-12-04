using Core.Entity;
using Core.Entity.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(d=>d.City).WithMany(m=>m.Users).HasForeignKey(fk=>fk.CityId).HasConstraintName("UserCityId");
            builder.HasMany(m=>m.Photos).WithOne(o=>o.User).HasForeignKey(fk=>fk.UserId).HasConstraintName("UserPhotoId");
        }
    }
}