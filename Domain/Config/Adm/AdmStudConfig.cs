using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Adm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Adm
{
    public class AdmStudConfig : IEntityTypeConfiguration<AdmStud>
    {
        public void Configure(EntityTypeBuilder<AdmStud> builder)
        {

            builder.ToTable("adm_stud");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);


            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.SchoolAdmStuds)
                .HasForeignKey(p => p.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.LkpSection)
              .WithMany(p => p.SectionAdmStuds)
              .HasForeignKey(p => p.SectionId)
              .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.ReligionLookup)
           .WithMany(p => p.ReligionAdmMasters)
           .HasForeignKey(p => p.ReligionId)
           .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.NationalityLookup)
        .WithMany(p => p.NationalityAdmMasters)
        .HasForeignKey(p => p.NationalityId)
        .OnDelete(DeleteBehavior.Restrict);





            builder.HasOne(p => p.GenderLookup)
        .WithMany(p => p.GenderAdmMasters)
        .HasForeignKey(p => p.GenderId)
        .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.YearLookup)
 .WithMany(p => p.YearAdmMasters)
 .HasForeignKey(p => p.YearId)
 .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.ClassLookup)
.WithMany(p => p.ClassAdmStuds)
.HasForeignKey(p => p.ClassId)
.OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.SequenceLookup)
.WithMany(p => p.SequenceAdmMasters)
.HasForeignKey(p => p.SequenceId)
.OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.BusLookup)
.WithMany(p => p.BusAdmStuds)
.HasForeignKey(p => p.BusId)
.OnDelete(DeleteBehavior.Restrict);




            builder.HasOne(p => p.TourLookup)
 .WithMany(p => p.TourAdmStuds)
 .HasForeignKey(p => p.TourId)
 .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(p => p.DiscountLookup)
 .WithMany(p => p.DiscountAdmMasters)
 .HasForeignKey(p => p.DiscountTypeId)
 .OnDelete(DeleteBehavior.Restrict);






        }
    }
}
