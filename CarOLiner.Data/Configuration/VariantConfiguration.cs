using CarOLiner.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Data.Configuration
{
    public  class VariantConfiguration : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> modelBuilder)
        {
            modelBuilder
                 .HasKey(v => v.VariantId);
            modelBuilder
                .HasOne(v => v.Item)
                .WithMany(i => i.Variants)
                .HasForeignKey(v => v.ItemId);
        }
    }
}
