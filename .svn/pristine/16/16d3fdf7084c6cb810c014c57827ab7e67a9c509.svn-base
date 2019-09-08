using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.AddLookupsConfig
{
    public class LkpBusConfig:IEntityTypeConfiguration<LkpBus>
    {
        public void Configure(EntityTypeBuilder<LkpBus> builder)
        {
            builder.ToTable("Lkp_Bus");
            builder.HasKey(key => key.Id);
            builder.Property(p => p.SidNo).IsRequired().HasMaxLength(100);
            builder.Property(p => p.DriverName).HasMaxLength(100);
            builder.Property(p => p.EvningSuper).HasMaxLength(100);
            builder.HasOne(p => p.LkpSchool)
                .WithMany(p => p.LkpBusses)
                .HasForeignKey(key => key.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}