
using Domain.Config.AddLookupsConfig;
using Domain.Config.Library;
using Domain.Config.LookupConfig;
using Domain.Config.Reg;
using Domain.Model.library;
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
            
            //======= Student Tables ======================================
            modelBuilder.ApplyConfiguration(new RegParentConfig());
            modelBuilder.ApplyConfiguration(new RegStudConfig());

            //==================================
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new AuthorConfig());



            return modelBuilder;

        }
    }
}
