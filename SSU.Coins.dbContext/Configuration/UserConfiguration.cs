using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(p => p.UserId);

            builder
                .Property(p => p.UserId)
                .UseIdentityColumn();

            builder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.LastName)
                .HasMaxLength(100);
            builder
                .Property(p => p.MiddleName)
                .HasMaxLength(100);

            builder
                .Property(p => p.Login)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.HashPassword)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(p => p.RoleWebSite)
                .WithOne(u => u.User)
                .HasForeignKey<RoleWebSite>(p => p.UserId);


            builder
                .Property(p => p.Avatar);

            /*builder
                .Property(p => p.UserCoins)
                .HasMaxLength(100000);*/



            builder
                .ToTable("User");
        }
    }
}
