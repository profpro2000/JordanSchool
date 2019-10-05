using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Config.AddLookupsConfig
{
    public class LkpBrothersDiscountRateConfig : IEntityTypeConfiguration<LkpBrothersDiscountRate>
    {
        public void Configure(EntityTypeBuilder<LkpBrothersDiscountRate> builder)
        {
            builder.ToTable("Lkp_Brothers_Discount_Rate");
            builder.HasKey(key => key.Id);


        }
    }
}
