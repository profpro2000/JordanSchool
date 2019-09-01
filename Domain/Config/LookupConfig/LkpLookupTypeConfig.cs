using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Lookups;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.LookupConfig
{
  public  class LkpLookupTypeConfig:IEntityTypeConfiguration<LkpLookupType>
    {

        public void Configure(EntityTypeBuilder<LkpLookupType> builder)
        {
            builder.ToTable("Lkp_Lookup_Type");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.Name).IsRequired();
            //builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Editable).HasMaxLength(1);
            
           

        }

    }
}
