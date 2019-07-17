using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Financial
{
    public class ClassFeeConfig : IEntityTypeConfiguration<ClassFee>
    {
        public void Configure(EntityTypeBuilder<ClassFee> builder)
        {
            builder.ToTable("Class_fees");
            builder.HasKey(key => key.Id);

            builder.HasOne(p => p.Class)
               .WithMany(p => p.ClassFees)
               .HasForeignKey(k => k.ClassId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Section)
               .WithMany(p => p.ClassFees)
               .HasForeignKey(k => k.SectionId)
               .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.FinItem)
   .WithMany(p => p.ClassFees)
   .HasForeignKey(k => k.FinItemId)
   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
