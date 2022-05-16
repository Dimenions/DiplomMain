using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .HasKey(p => p.CountryId);

            builder
                .Property(p => p.CountryId)
                .UseIdentityColumn();

            builder
                .Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .ToTable("Country");
        }
    }
}
