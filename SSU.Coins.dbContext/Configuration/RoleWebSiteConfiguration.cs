using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext.Configuration
{
    internal class RoleWebSiteConfiguration : IEntityTypeConfiguration<RoleWebSite>
    {
        public void Configure(EntityTypeBuilder<RoleWebSite> builder)
        {
            builder
                 .HasKey(p => p.RoleWebSiteId);

            builder
                .Property(p => p.RoleWebSiteId)
                .UseIdentityColumn();

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .ToTable("RoleWebSite");
        }
    }
}
