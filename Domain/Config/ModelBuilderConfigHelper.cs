
using Domain.Config.AddLookupsConfig;
using Domain.Config.Financial;
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



            ///=====================Financial tables=================
            modelBuilder.ApplyConfiguration(new FinItemConfig());
            modelBuilder.ApplyConfiguration(new SchoolFeeConfig());
            modelBuilder.ApplyConfiguration(new ClassFeeConfig());
            modelBuilder.ApplyConfiguration(new StudentFeeConfig());



            return modelBuilder;

        }
    }
}
