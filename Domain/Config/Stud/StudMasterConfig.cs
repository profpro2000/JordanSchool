using Domain.Model.Stud;
using  Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Config.Stud
{
    public class StudMasterConfig:IEntityTypeConfiguration<StudMaster>
    {
        public void Configure(EntityTypeBuilder<StudMaster> builder)
        {
            builder.ToTable("Stud_Master");
            builder.HasKey(k => k.Id);
            builder.Property(u => u.StudNo).IsRequired();
            builder.HasIndex(p => p.StudNo).IsUnique();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(75);
            builder.HasOne(p => p.StudParent)
                .WithMany(p => p.StudMasters)
                .HasForeignKey(k => k.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.GenderLookup)
                .WithMany(p => p.GenderStudMasters)
                .HasForeignKey(k => k.GenderId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.JoinYearLookup)
                .WithMany(p => p.JoinYearStudMasters)
                .HasForeignKey(k => k.JoinYearId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.JoinTermLookup)
                .WithMany(p => p.JoinTermStudMasters)
                .HasForeignKey(k => k.JoinTermId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.SchoolStudMasters)
                .HasForeignKey(k => k.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LkpSection)
                .WithMany(p => p.SectionStudMasters)
                .HasForeignKey(k => k.SectionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LkpClass)
                .WithMany(p => p.ClassStudMasters)
                .HasForeignKey(k => k.SectionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.JoinClassSeqLookup)
                .WithMany(p => p.JoinClassSeqStudMasters)
                .HasForeignKey(k => k.JoinClassSeqId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.StudHealthLookup)
                .WithMany(p => p.HealthStudMasters)
                .HasForeignKey(k => k.StudHealthId)
                .OnDelete(DeleteBehavior.Restrict);



            //throw new System.NotImplementedException();
        }
        
    }
}