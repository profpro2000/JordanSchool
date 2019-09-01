using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using  Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Config.AddLookupsConfig
{
  public  class LkpTourConfig:IEntityTypeConfiguration<LkpTour>
    {
        public void Configure(EntityTypeBuilder<LkpTour> builder)
        {
            builder.ToTable("LkpTour");
            builder.HasKey(key => key.Id);
            //builder.Property(p => p.TourName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.TourFullPrice).HasDefaultValue(0);
            builder.Property(p => p.TourHalfPrice).HasDefaultValue(0);
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.LkpTours)
                .HasForeignKey(key => key.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Tour)
               .WithMany(p => p.LkpTour)
               .HasForeignKey(key => key.TourNameId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
