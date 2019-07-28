using Domain.Model.Adm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.Adm
{
  public  class AdmStudConfig: IEntityTypeConfiguration<AdmStud>
    {

        public void Configure(EntityTypeBuilder<AdmStud> builder)
        {
            builder.ToTable("Adm_Stud");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.ParentId).IsRequired();

            builder.HasOne(p => p.Parent)
                .WithMany(p => p.ParentAdm)
                .HasForeignKey(key => key.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.SchoolAdm)
                .HasForeignKey(key => key.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LkpSection)
                .WithMany(p => p.SectionAdm)
                .HasForeignKey(key => key.SectionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Bus)
                .WithMany(p => p.BusAdm)
                .HasForeignKey(key=>key.BusId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Tour)
                .WithMany(p => p.TourAdm)
                .HasForeignKey(key => key.TourId)
                .OnDelete(DeleteBehavior.Restrict);

            //Lookups
            //builder.Ignore("Nationality");
            builder.HasOne(p => p.Religion)
                .WithMany(p => p.ReligionAdm)
                .HasForeignKey(key => key.ReligionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Gender)
                .WithMany(p => p.GenderAdm)
                .HasForeignKey(key => key.GenderId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Nationality)
                .WithMany(p => p.NationalityAdm)
                .HasForeignKey(key => key.NationalityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Years)
                .WithMany(p => p.YearsAdm)
                .HasForeignKey(key => key.YearId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ClassSeq)
                .WithMany(p => p.ClassSeqAdm)
                .HasForeignKey(key => key.ClassSeqId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.TourType)
                .WithMany(p => p.TourType)
                .HasForeignKey(key => key.TourTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Approved)
                .WithMany(p => p.ApprovedAdm)
                .HasForeignKey(key => key.ApprovedId)
                .OnDelete(DeleteBehavior.Restrict);
            //
            builder.HasOne(p => p.JoinYearLookup)
               .WithMany(p => p.JoinYearAdm)
               .HasForeignKey(k => k.JoinYearId)
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.JoinTermLookup)
              .WithMany(p => p.JoinTermAdm)
              .HasForeignKey(k => k.JoinTermId)
              .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.StudHealthLookup)
               .WithMany(p => p.HealthStudAdm)
               .HasForeignKey(k => k.StudHealthId)
               .OnDelete(DeleteBehavior.Restrict);



        }


    }
}
