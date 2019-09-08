using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.AddLookupsConfig
{
    public class LkpClassConfig : IEntityTypeConfiguration<LkpClass>
    {
        public void Configure(EntityTypeBuilder<LkpClass> builder)
        {
            builder.ToTable("Lkp_Class");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.Aname).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Lname).HasMaxLength(100);
            builder.Property(p => p.Age).HasMaxLength(2);
            builder.Property(p => p.Amt).HasMaxLength(10).HasDefaultValue(0);
            builder.Property(p => p.Capacity).HasMaxLength(3).HasDefaultValue(0);
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.LkpClasses)
                .HasForeignKey(key => key.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LkpSection)
                .WithMany(p => p.LkpClasses)
                .HasForeignKey(key => key.SectionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.YearsLookup)
                .WithMany(p => p.Classes)
                .HasForeignKey(key => key.YearId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}