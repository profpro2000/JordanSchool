using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Fin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Fin
{
    public class FinItemConfig : IEntityTypeConfiguration<FinItem>
    {
        public void Configure(EntityTypeBuilder<FinItem> builder)
        {


            builder.ToTable("Fin_item");
            builder.HasKey(k => k.Id);



            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.SchoolFinItems)
                .HasForeignKey(k => k.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.LkpSectoin)
                .WithMany(p => p.SectionFinItems)
                .HasForeignKey(k => k.SectionId)
                .OnDelete(DeleteBehavior.Restrict);


               builder.HasOne(p => p.FinItemTypeLookup)
                .WithMany(p => p.FinItemTypeMasters)
                .HasForeignKey(k => k.TypeId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.VisibleToLookup)
                .WithMany(p => p.VisibleToMasters)
                .HasForeignKey(k => k.VisibleToId)
                .OnDelete(DeleteBehavior.Restrict);









        }
    }
}
