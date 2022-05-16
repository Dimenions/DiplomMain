﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration
{
    public class CoinConfiguration : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder
                .HasKey(p => p.CoinId);

            builder
                .Property(p => p.CoinId)
                .UseIdentityColumn();

            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(1000);
            //-----------------Для продажи 
            builder
                .Property(p => p.Activ) // Активна продажа или нет
                .IsRequired();

            builder
                .HasOne(p => p.User)
                .WithOne(u => u.Coin)
                .HasForeignKey<Coin>(p => p.UserId);
            //----------------Для коллекции
            builder
                .Property(p => p.IsPresentation) //На сайте или в коллекции
                .IsRequired();

            //----------------
            builder
                .Property(p => p.Date)
                .IsRequired();

            builder
                .Property(p => p.Price)
                .HasMaxLength(100);

            builder
                .Property(p => p.Description)
                .HasMaxLength(10000);

            builder
                .HasOne(p => p.Country)
                .WithOne(u => u.Coin)
                .HasForeignKey<Coin>(p => p.IdCountry);//Или Country

            builder
                .HasOne(p => p.Material)
                .WithOne(u => u.Coin)
                .HasForeignKey<Coin>(p => p.IdMaterial);// Или Country

            builder
                .Property(p => p.Picture);

            builder
                .ToTable("Coin");
        }
        //Update-Database
    }
}
