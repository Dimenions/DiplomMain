using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration
{
    internal class SaleCoinsConfiguration : IEntityTypeConfiguration<SaleCoins>
    {
        public void Configure(EntityTypeBuilder<SaleCoins> builder)
        {
            builder
                .HasKey(p => p.SaleCoinsId);

            builder
                .Property(p => p.SaleCoinsId)
                .UseIdentityColumn();

            builder
                .HasOne(p => p.User)
                .WithOne(u => u.SaleCoins)
                .HasForeignKey<SaleCoins>(p => p.UserId);

            /*builder
                .HasOne<Coin>(p => p.Coin)
                .WithMany(u => u.SaleCoins)
                .HasForeignKey<SaleCoins>(p => p.CoinId);*/

            builder
                .HasKey(p => p.SaleCoin);

            builder
                .Property(p => p.Activ)
                .IsRequired();

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
