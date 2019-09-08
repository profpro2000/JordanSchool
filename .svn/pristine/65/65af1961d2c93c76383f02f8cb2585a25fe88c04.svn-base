using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Lookups;
using Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.LookupConfig
{
  public  class LkpCalendarConfig:IEntityTypeConfiguration<LkpCalendar>
    {

        public void Configure(EntityTypeBuilder<LkpCalendar> builder)
        {
            builder.ToTable("Lkp_Calendar");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.YearId).IsRequired();
            builder.Property(p => p.ItemId).IsRequired();
            builder.Property(p => p.SectionId).IsRequired();
            builder.HasOne(p => p.LkpItemCalendar)
                .WithMany(p => p.LkpCalendar)
                .HasForeignKey(key => key.ItemId);
            builder.Property(p => p.Note).HasMaxLength(400);
        }

    }
}
