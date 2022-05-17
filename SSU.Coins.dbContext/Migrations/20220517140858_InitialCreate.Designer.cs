﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SSU.Coins.dbContext.Migrations
{
    [DbContext(typeof(CoinsContext))]
    [Migration("20220517140858_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SSU.Coins.dbContext.Coin", b =>
                {
                    b.Property<int>("CoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoinId"), 1L, 1);

                    b.Property<bool>("Activ")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPresentation")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CoinId");

                    b.HasIndex("UserId");

                    b.ToTable("Coins");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<int>("CoinId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.HasIndex("CoinId")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"), 1L, 1);

                    b.Property<int>("CoinId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.HasIndex("CoinId")
                        .IsUnique();

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.RoleWebSite", b =>
                {
                    b.Property<int>("RoleWebSiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleWebSiteId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleWebSiteId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("RoleWebSites");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<byte[]>("Avatar")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HashPassword")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.Coin", b =>
                {
                    b.HasOne("SSU.Coins.dbContext.User", "User")
                        .WithMany("Coins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.Country", b =>
                {
                    b.HasOne("SSU.Coins.dbContext.Coin", "Coin")
                        .WithOne("Country")
                        .HasForeignKey("SSU.Coins.dbContext.Country", "CoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coin");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.Material", b =>
                {
                    b.HasOne("SSU.Coins.dbContext.Coin", "Coin")
                        .WithOne("Material")
                        .HasForeignKey("SSU.Coins.dbContext.Material", "CoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coin");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.RoleWebSite", b =>
                {
                    b.HasOne("SSU.Coins.dbContext.User", "User")
                        .WithOne("RoleWebSite")
                        .HasForeignKey("SSU.Coins.dbContext.RoleWebSite", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SSU.Coins.dbContext.Coin", b =>
                {
                    b.Navigation("Country")
                        .IsRequired();

                    b.Navigation("Material")
                        .IsRequired();
                });

            modelBuilder.Entity("SSU.Coins.dbContext.User", b =>
                {
                    b.Navigation("Coins");

                    b.Navigation("RoleWebSite")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}