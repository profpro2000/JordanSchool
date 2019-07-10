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

        }
    }
}
