using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Financial
{
    public class StudentFeeConfig : IEntityTypeConfiguration<StudentFee>

    {
        public void Configure(EntityTypeBuilder<StudentFee> builder)
        {
            builder.ToTable("Student_fees");
            builder.HasKey(Key => Key.Id);


            builder.HasOne(p => p.Student)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.StudentId)
   .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.Year)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.YearId)
   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.FinItem)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.FinItemId)
   .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.Payment)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.PaymentId)
   .OnDelete(DeleteBehavior.Restrict);





        }
    }
}
