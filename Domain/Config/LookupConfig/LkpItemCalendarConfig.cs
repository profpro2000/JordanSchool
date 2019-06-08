using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Domain.Model.Lookups;

namespace Domain.Config.LookupConfig
{
    public class LkpItemCalendarConfig : IEntityTypeConfiguration<LkpItemCalendar>
    {

        public void Configure(EntityTypeBuilder<LkpItemCalendar> builder)
        {
            builder.ToTable("Lkp_Item_Calendar");
            builder.HasKey(key => key.Id);
           // builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(100);


        }

    }
}

