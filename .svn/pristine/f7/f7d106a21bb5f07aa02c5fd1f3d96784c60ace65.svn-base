using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using  Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.AddLookupsConfig
{
 public   class LkpSectionConfig: IEntityTypeConfiguration<LkpSection>
    {
        public void Configure(EntityTypeBuilder<LkpSection> builder)
        {
            builder.ToTable("Lkp_Section");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.SectionName).IsRequired().HasMaxLength(120);
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.LkpSections)
                .HasForeignKey(key => key.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
