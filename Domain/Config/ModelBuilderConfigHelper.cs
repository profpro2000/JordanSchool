
using Domain.Config.AddLookupsConfig;
using Domain.Config.LookupConfig;
using Domain.Config.Reg;
using Microsoft.EntityFrameworkCore;

namespace Domain.Config
{
  public  class ModelBuilderConfigHelper
    {

        public static ModelBuilder OnModelCreating(ModelBuilder modelBuilder)
        {

          
            //========== System Table & lookups configuration================
            modelBuilder.ApplyConfiguration(new LkpItemCalendarConfig());
            modelBuilder.ApplyConfiguration(new LkpCalendarConfig());
            modelBuilder.ApplyConfiguration(new LkpLookupTypeConfig());
            modelBuilder.ApplyConfiguration(new LkpLookupConfig());
            modelBuilder.ApplyConfiguration(new  LkpSchoolConfig());
            modelBuilder.ApplyConfiguration(new LkpSectionConfig());
            modelBuilder.ApplyConfiguration(new LkpTourConfig());
            modelBuilder.ApplyConfiguration(new LkpBusConfig());
            modelBuilder.ApplyConfiguration(new LkpClassConfig());
            modelBuilder.ApplyConfiguration(new LkpDocumentConfig());
            
            //======= Student Tables ======================================
            modelBuilder.ApplyConfiguration(new RegParentConfig());
            modelBuilder.ApplyConfiguration(new RegStudConfig());

            return modelBuilder;

        }
    }
}
