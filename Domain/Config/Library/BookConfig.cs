using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Library
{
    public class BookConfig : IEntityTypeConfiguration<Book>

    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(key => key.Id);

        }
    }
}
