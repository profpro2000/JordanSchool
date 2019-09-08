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


            builder.HasOne(p => p.RegParent)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.ParentId)
   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Student)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.StudentId)
   .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.Year)
   .WithMany(p => p.Years)
   .HasForeignKey(k => k.YearId)
   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.FinItem)
   .WithMany(p => p.StudentFees)
   .HasForeignKey(k => k.FinItemId)
   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.VoucherType)
                            .WithMany(p => p.VoucherTypes)
                            .HasForeignKey(k => k.VoucherTypeId)
                            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.VoucherStatus)
                .WithMany(p => p.VoucherStatuses)
                .HasForeignKey(k => k.VoucherStatusId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.PaymentMethod)
    .WithMany(p => p.PaymentMethods)
    .HasForeignKey(k => k.PaymentMethodId)
    .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
