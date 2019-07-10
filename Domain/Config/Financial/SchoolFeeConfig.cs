using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Financial
{
    public class SchoolFeeConfig : IEntityTypeConfiguration<SchoolFee>

    {
        public void Configure(EntityTypeBuilder<SchoolFee> builder)
        {
            builder.ToTable("School_Fees");
            builder.HasKey(key => key.Id);
            builder.HasOne(p => p.school)
               .WithMany(p => p.SchoolFees)
               .HasForeignKey(k => k.SchoolId)
               .OnDelete(DeleteBehavior.Restrict);

         builder.HasOne(p => p.Year)
              .WithMany(p => p.SchoolFees)
              .HasForeignKey(k => k.YearId)
             .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(p => p.FinItem)
            .WithMany(p => p.SchoolFees)
            .HasForeignKey(k => k.FinItemId)
            .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
