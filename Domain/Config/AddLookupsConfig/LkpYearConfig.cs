using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.AddLookupsConfig
{
  public  class LkpYearConfig : IEntityTypeConfiguration<LkpYear>
    {
        public void Configure(EntityTypeBuilder<LkpYear> builder)
        {
            builder.ToTable("Lkp_Year");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.AName).IsRequired().HasMaxLength(200);
        }


    }
}
