using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Financial
{
    class PaymentChequeConfig : IEntityTypeConfiguration<Paymentcheque>
    {
        public void Configure(EntityTypeBuilder<Paymentcheque> builder)
        {
            builder.ToTable("Payment_cheques");
            builder.HasKey(key => key.Id);

            builder.HasOne(p => p.Bank)
               .WithMany(p => p.Banks)
               .HasForeignKey(p => p.BankId)
                 .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.Payment)
   .WithMany(p => p.Paymentcheques)
   .HasForeignKey(p => p.PaymentId)
     .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
