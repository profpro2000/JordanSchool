using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Financial
{
    public class FinItemConfig : IEntityTypeConfiguration<FinItem>
    {
        public void Configure(EntityTypeBuilder<FinItem> builder)
        {
            builder.ToTable("Fin_items");
            builder.HasKey(key => key.Id);


        }
    }
}
