using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Financial
{
    public class FinItemConfig : IEntityTypeConfiguration<FinItem>
    {
        public void Configure(EntityTypeBuilder<FinItem> builder)
        {
            builder.ToTable("Fin_items");
            builder.HasKey(key => key.Id);


            builder.HasOne(p => p.vpTypeLookup)
    .WithMany(p => p.VpTypes)
    .HasForeignKey(k => k.vpTypeId)
    .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.cdTypeLookup)
.WithMany(p => p.CdTypes)
.HasForeignKey(k => k.cdTypeId)
.OnDelete(DeleteBehavior.Restrict);


        }
    }
}
