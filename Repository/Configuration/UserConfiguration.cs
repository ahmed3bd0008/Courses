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
            builder.HasOne(d=>d.City).WithOne(m=>m.AppUser).HasForeignKey<AppUser>(fk=>fk.CityId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(m=>m.Photos).WithOne().HasForeignKey(fk=>fk.AppUserId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("AppUserId");
        }
    }
}