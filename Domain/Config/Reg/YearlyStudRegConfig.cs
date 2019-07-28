using Domain.Model.Adm;
using Domain.Model.Reg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Config.Adm
{
  public  class YearlyStudRegConfig: IEntityTypeConfiguration<YearlyStudReg>
    {

        public void Configure(EntityTypeBuilder<YearlyStudReg> builder)
        {
            builder.ToTable("Reg_StudYearly");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.ParentId).IsRequired();

            builder.HasOne(p => p.Parent)
                .WithMany(p => p.ParentYearlyStudReg)
                .HasForeignKey(key => key.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(p => p.AdmStuds)
            //    .WithMany(p => p.AdmStudYearlyStudRegs)
            //    .HasForeignKey(key => key.StudId);
            //    //.OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.YearlyStudRegs)
                .HasForeignKey(key => key.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LkpSection)
                .WithMany(p => p.YearlyStudRegs)
                .HasForeignKey(key => key.SectionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Bus)
                .WithMany(p => p.YearlyStudRegs)
                .HasForeignKey(key=>key.BusId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Tour)
                .WithMany(p => p.YearlyStudRegs)
                .HasForeignKey(key => key.TourId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Years)
                .WithMany(p => p.YearsYearlyStudReg)
                .HasForeignKey(key => key.YearId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Class)
             .WithMany(p => p.YearlyStudRegs)
             .HasForeignKey(key => key.ClassId)
             .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ClassSeq)
                .WithMany(p => p.ClassSeqYearlyStudReg)
                .HasForeignKey(key => key.ClassSeqId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.TourType)
                .WithMany(p => p.TourTypeYearlyStudReg)
                .HasForeignKey(key => key.TourTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Approved)
                .WithMany(p => p.ApprovedYearlyStudReg)
                .HasForeignKey(key => key.ApprovedId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.JoinTermLookup)
               .WithMany(p => p.JoinTermYearlyStudReg)
               .HasForeignKey(k => k.JoinTermId)
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.StudStatus)
             .WithMany(p => p.StudStatusYearlyStudReg)
             .HasForeignKey(k => k.StudStatusId)
             .OnDelete(DeleteBehavior.Restrict);





        }


    }
}
