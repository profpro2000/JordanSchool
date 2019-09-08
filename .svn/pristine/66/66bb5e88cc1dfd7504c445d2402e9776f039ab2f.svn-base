using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Domain.Config;
using Domain.Model.AddLookups;
using Domain.Model.Adm;
using Domain.Model.Lookups;
using Domain.Model.Financial;
using Domain.Model.Lookups;
using Domain.Model.Reg;
using Microsoft.EntityFrameworkCore;
using Domain.Model.Users;
using System.Threading.Tasks;

namespace Domain
{
    public class SchoolDbContext : DbContext
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


        //=============Users =================
        public DbSet<SysUsers> Users { get; set; }
        public DbSet<UserSchool> UserSchools { get; set; }
        public DbSet<SysForms> SysForms { get; set; }
        public DbSet<SysRoleForms> SysRoleForms { get; set; }
        public DbSet<SysRoles> SysRoles { get; set; }
        public DbSet<SysUsers> SysUsers { get; set; }
        public DbSet<SysUsersRoles> SysUsersRoles { get; set; }



        //========= Lookups Tables ====================================
        //public DbSet<LookupType> LookupTypes { get; set; }

        public DbSet<LkpItemCalendar> LkpItemCalendars { get; set; }
        public DbSet<LkpCalendar> LkpCalendars { get; set; }
        public DbSet<LkpLookupType> LkpLookupTypes { get; set; }
        public DbSet<LkpLookup> LkpLookups { get; set; }
        //==================Additional Lookups =================
        public DbSet<LkpSchool> LkpSchools { get; set; }
        public DbSet<LkpSection> LkpSections { get; set; }
        public DbSet<LkpTour> LkpTours { get; set; }
        public DbSet<LkpBus> LkpBusses { get; set; }
        public DbSet<LkpClass> LkpClasses { get; set; }
        public DbSet<LkpYear> LkpYears { get; set; }

        //================Stud Module =========================
        public DbSet<RegParent> RegParents { get; set; }
        public DbSet<RegStud> RegStuds { get; set; }
        public DbSet<YearlyStudReg> YearlyStudRegs { get; set; }

        //=========== Admission Module===================
        public DbSet<AdmStud> AdmStuds { get; set; }



        //==================financial=============
        public DbSet<FinItem> FinItems { set; get; }
        public DbSet<SchoolFee> SchoolFees { set; get; }
        public DbSet<ClassFee> ClassFees { set; get; }
        public DbSet<StudentFee> StudentFees { set; get; }
        // public DbSet<Payment> Payments { set; get; }
        public DbSet<PaymentCheque> PaymentCheques { set; get; }


        //==============Views
        public DbQuery<RegStudYearlyVw> RegStudYearlyVw { get; set; }
        public DbQuery<RegStudCardReportVw> RegStudCardReportVw { get; set; }
        public DbQuery<SysUserMenuVw> SysUserMenuVw { get; set; }
        public DbQuery<FinStudCard> FinStudCard { get; set; }
    }
}