using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.AddLookupsConfig
{
 public   class LkpClassFeesConfig : IEntityTypeConfiguration<LkpClassFees>
    {
      

        public void Configure(EntityTypeBuilder<LkpClassFees> builder)
        {
            builder.ToTable("Lkp_class_fees");
            builder.HasKey(key => key.Id);
            builder.HasOne(p => p.Classes)
                .WithMany(p => p.LkpClassFees)
                .HasForeignKey(k => k.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Years)
                .WithMany(p => p.LkpClassFees)
                .HasForeignKey(k => k.YearId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
