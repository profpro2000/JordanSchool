using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Financial
{
    public class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(key => key.Id);

            builder.HasOne(p => p.VoucherType)
                .WithMany(p => p.VoucherTypes)
                .HasForeignKey(p => p.VoucherTypeId)
                  .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.VoucherStatus)
                .WithMany(p => p.VoucherStatuses)
                .HasForeignKey(p => p.VoucherStatusId)
                 .OnDelete(DeleteBehavior.Restrict);





            builder.HasOne(p => p.RegParent)
                .WithMany(p => p.Payments)
                .HasForeignKey(p => p.RegParentId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
