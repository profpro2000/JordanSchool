using Domain.Model.Stud;
using  Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.Stud
{
    public class StudParentConfig:IEntityTypeConfiguration<StudParent>
    {
        public void Configure(EntityTypeBuilder<StudParent> builder)
        {
            builder.ToTable("Stud_Parent");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.SecondName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.FamilyName).IsRequired().HasMaxLength(100);

            builder.HasOne(p => p.ReligionLookup)
                .WithMany(p => p.ReligionParents)
                .HasForeignKey(key => key.ReligionId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ParentRelationLookup)
                .WithMany(p => p.ParentRelationParents)
                .HasForeignKey(key => key.ParentRelationId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.NationalityLookup)
                .WithMany(p => p.NationalityParents)
                .HasForeignKey(key=>key.NationalityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.CityLookup)
                .WithMany(p => p.CityParents)
                .HasForeignKey(key=>key.CityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.FatherEducationLookup)
                .WithMany(p => p.FatherEducationParents)
                .HasForeignKey(k => k.FatherEducationId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MatherEducationLookup)
                .WithMany(p => p.MatherEducationParents)
                .HasForeignKey(k => k.MatherEducationId)
                .OnDelete(DeleteBehavior.Restrict);




            //throw new System.NotImplementedException();
        }
        
    }
}