using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using  Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.AddLookupsConfig
{
   public class LkpSchoolConfig:IEntityTypeConfiguration<LkpSchool>
    {
        public void Configure(EntityTypeBuilder<LkpSchool> builder)
        {
            builder.ToTable("Lkp_School");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.Aname).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.CitesLookup)
                .WithMany(p => p.LkpSchool)
                .HasForeignKey(key => key.CityId);


        }



    }
}
