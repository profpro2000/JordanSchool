﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Financial
{
    class PaymentChequeConfig : IEntityTypeConfiguration<PaymentCheque>
    {
        public void Configure(EntityTypeBuilder<PaymentCheque> builder)
        {
            builder.ToTable("Payment_cheques");
            builder.HasKey(key => key.Id);

            builder.HasOne(p => p.Bank)
               .WithMany(p => p.Banks)
               .HasForeignKey(p => p.BankId)
                 .OnDelete(DeleteBehavior.Restrict);

          /*  builder.HasOne(p => p.StudentFee)
   .WithMany(p => p.Paymentcheques)
   .HasForeignKey(p => p.StudentFeeId)
     .OnDelete(DeleteBehavior.Restrict);*/



        }
    }
}
