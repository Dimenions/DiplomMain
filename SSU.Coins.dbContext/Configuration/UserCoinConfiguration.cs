using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration
{
    internal class UserCoinConfiguration : IEntityTypeConfiguration<UserCoin>
    {
        public void Configure(EntityTypeBuilder<UserCoin> builder)
        {
            builder
                .HasKey(p => p.UserCoinId);

            builder
                .Property(p => p.UserCoinId)
                .UseIdentityColumn();

            builder
                .HasOne(p => p.User)
                .WithOne(u => u.UserCoin)
                .HasForeignKey<UserCoin>(p => p.UserId);

            /*builder
                .HasOne(p => p.UserCoin)
                .WithMany(u => u.Coins)
                .HasForeignKey<UserCoin>(p => p.CoinId);*/

            builder
                .Property(p => p.Information)
                .HasMaxLength(1000);

            builder
                .Property(p => p.Picture);

            builder
                .ToTable("SaleCoins");
        }
    }
}
