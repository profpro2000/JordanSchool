﻿
using Domain.Config.AddLookupsConfig;
using Domain.Config.Adm;
using Domain.Config.Financial;
using Domain.Config.LookupConfig;
using Domain.Config.Reg;
using Domain.Config.UsersConfigs;
using Microsoft.EntityFrameworkCore;

namespace Domain.Config
{
  public  class ModelBuilderConfigHelper
    {

        public static ModelBuilder OnModelCreating(ModelBuilder modelBuilder)
        {

            //=========  Sys_Users ======================================
            modelBuilder.ApplyConfiguration(new UsersConfig());
            modelBuilder.ApplyConfiguration(new UserSchoolsConfig());


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
            modelBuilder.ApplyConfiguration(new AdmStudConfig());

            modelBuilder.ApplyConfiguration(new LkpYearConfig());

            //======= Student Tables ======================================
            modelBuilder.ApplyConfiguration(new RegParentConfig());
            modelBuilder.ApplyConfiguration(new RegStudConfig());
            modelBuilder.ApplyConfiguration(new YearlyStudRegConfig());

            //=======Addmission Tables ======================================
            modelBuilder.ApplyConfiguration(new AdmStudConfig());
            




            ///=====================Financial tables=================
            modelBuilder.ApplyConfiguration(new FinItemConfig());
            modelBuilder.ApplyConfiguration(new SchoolFeeConfig());
            modelBuilder.ApplyConfiguration(new ClassFeeConfig());
            modelBuilder.ApplyConfiguration(new StudentFeeConfig());
            modelBuilder.ApplyConfiguration(new PaymentConfig());




            return modelBuilder;

        }
    }
}
