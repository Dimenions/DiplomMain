using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration 
{
    internal class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder
                 .HasKey(p => p.MaterialId);

            builder
                .Property(p => p.MaterialId)
                .UseIdentityColumn();

            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .ToTable("Material");

        }
    }
}
