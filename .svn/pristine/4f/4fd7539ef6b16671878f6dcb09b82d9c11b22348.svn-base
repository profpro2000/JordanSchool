using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Lookups;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Microsoft.EntityFrameworkCore;

namespace Domain.Config.LookupConfig
{
   public class LkpLookupConfig: IEntityTypeConfiguration<LkpLookup>
    {
        public void Configure(EntityTypeBuilder<LkpLookup>builder)
        {
            builder.ToTable("Lkp_Lookup");
            builder.HasKey(key => key.Id);
           // builder.Property(p => p.AName).IsRequired().HasMaxLength(200);
            builder.HasOne(p => p.LkpLookupType)
                .WithMany(p => p.LkpLookups)
                .HasForeignKey(key => key.TypeId);


        }
    }
}
