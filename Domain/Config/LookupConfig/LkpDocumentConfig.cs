using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.LookupConfig
{
    public class LkpDocumentConfig : IEntityTypeConfiguration<LkpDocument>
    {
        public void Configure(EntityTypeBuilder<LkpDocument> builder)
        {
            builder.ToTable("lkp_document");
            builder.HasKey(key => key.Id);
                builder.Property(p => p.DocumentId).IsRequired().HasMaxLength(200);
            builder.HasOne(p => p.DocumentLookup)
                .WithMany(p => p.DocumentMasters)
                .HasForeignKey(p => p.DocumentId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(p => p.SectionId).IsRequired();
            builder.HasOne(p => p.SectionLookup)
                .WithMany(p => p.SectionMasters)
                .HasForeignKey(p => p.SectionId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(p => p.MandotoryId).IsRequired();
            builder.HasOne(p => p.MandatoryLookup)
                .WithMany(p => p.MandatoryMasters)
                .HasForeignKey(p => p.MandotoryId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(p => p.ActiveId).IsRequired();
            builder.HasOne(p => p.ActiveLookup)
                .WithMany(p => p.ActiveMasters)
                .HasForeignKey(p => p.ActiveId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
