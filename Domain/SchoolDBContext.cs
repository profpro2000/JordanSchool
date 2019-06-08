﻿ using System;
using System.Collections.Generic;
 using System.Data;
 using System.Text;
using Domain.Config;
 using Domain.Model.AddLookups;
 using Domain.Model.Lookups;
 using Domain.Model.Stud;
 using Microsoft.EntityFrameworkCore;

namespace Domain
{
  public  class SchoolDbContext: DbContext
    {

        public DbContextOptions Options { get; }

        public SchoolDbContext(DbContextOptions options) : base(options)
        {
            Options = options;
            // ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(ModelBuilderConfigHelper.OnModelCreating(modelBuilder));
            
        }

        //========= Lookups Tables ====================================
        //public DbSet<LookupType> LookupTypes { get; set; }

        public  DbSet<LkpItemCalendar> LkpItemCalendars { get; set; }
        public  DbSet<LkpCalendar> LkpCalendars { get; set; }
        public  DbSet<LkpLookupType> LkpLookupTypes { get; set; }
        public DbSet<LkpLookup> LkpLookups { get; set; }
        //==================Additional Lookups =================
        public  DbSet<LkpSchool> LkpSchools { get; set; }
        public  DbSet<LkpSection> LkpSections { get; set; }
        public  DbSet<LkpTour> LkpTours { get; set; }
        public  DbSet<LkpBus> LkpBusses { get; set; }
        public DbSet<LkpClass> LkpClasses { get; set; }
        
        //================Stud Module =========================
        public DbSet<StudParent> StudParents { get; set; }
        public DbSet<StudMaster> StudMasters { get; set; }

    }
}