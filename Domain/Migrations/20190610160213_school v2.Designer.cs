﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20190610160213_school v2")]
    partial class schoolv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Model.AddLookups.LkpBus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DriverName")
                        .HasMaxLength(100);

                    b.Property<string>("EvningSuper")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("Mobile");

                    b.Property<string>("MorningSuper");

                    b.Property<int>("SchoolId");

                    b.Property<string>("SidNo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Lkp_Bus");
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Age")
                        .HasMaxLength(2);

                    b.Property<int>("Amt")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasDefaultValue(0);

                    b.Property<string>("Aname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Capacity")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("Lname")
                        .HasMaxLength(100);

                    b.Property<int>("SchoolId");

                    b.Property<int>("SectionId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.Property<int>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SectionId");

                    b.HasIndex("YearId");

                    b.ToTable("Lkp_Class");
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpSchool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Aname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("CityId");

                    b.Property<string>("FaceBook");

                    b.Property<string>("Fax");

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("Lname");

                    b.Property<string>("Mobile");

                    b.Property<string>("Tel");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.Property<string>("WebPage");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Lkp_School");
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<int>("ManagerId");

                    b.Property<string>("NationalId");

                    b.Property<int>("SchoolId");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Lkp_Section");
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpTour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<int>("SchoolId");

                    b.Property<int>("TourFullPrice")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("TourHalfPrice")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("TourName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("LkpTour");
                });

            modelBuilder.Entity("Domain.Model.Adm.AdmStud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApproveDate");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("BusId");

                    b.Property<string>("BusNotes");

                    b.Property<int>("ClassId");

                    b.Property<int>("DiscountTypeId");

                    b.Property<DateTime?>("EntryDate");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("GenderId");

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<int>("IsApproved");

                    b.Property<int>("NationalityId");

                    b.Property<string>("Notes");

                    b.Property<int>("ReligionId");

                    b.Property<int>("SchoolId");

                    b.Property<int>("SectionId");

                    b.Property<int>("SequenceId");

                    b.Property<int>("StudNo");

                    b.Property<int>("StudentBrotherSeq");

                    b.Property<int>("TourId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.Property<int>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("ClassId");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SectionId");

                    b.HasIndex("SequenceId");

                    b.HasIndex("TourId");

                    b.HasIndex("YearId");

                    b.ToTable("adm_stud");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FromDate");

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<int>("ItemId");

                    b.Property<string>("Note")
                        .HasMaxLength(400);

                    b.Property<int>("SectionId");

                    b.Property<DateTime>("ToDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.Property<int>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Lkp_Calendar");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActiveId");

                    b.Property<int>("DocumentId")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<int>("MandotoryId");

                    b.Property<int>("SectionId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("ActiveId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("MandotoryId");

                    b.HasIndex("SectionId");

                    b.ToTable("lkp_document");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpItemCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.ToTable("Lkp_Item_Calendar");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpLookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("LName");

                    b.Property<int>("ParentId");

                    b.Property<int>("TypeId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Lkp_Lookup");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpLookupType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Lkp_Lookup_Type");
                });

            modelBuilder.Entity("Domain.Model.Reg.RegParent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BuildingNo");

                    b.Property<int?>("CityId");

                    b.Property<string>("FamilyAssistance");

                    b.Property<int?>("FamilyIncome");

                    b.Property<string>("FamilyLName");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("FamilySize");

                    b.Property<int?>("FatherEducationId");

                    b.Property<string>("FatherMobile");

                    b.Property<string>("FatherSpec");

                    b.Property<string>("FirstLName");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("IdNum");

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("Locality1");

                    b.Property<string>("Locality2");

                    b.Property<int?>("MatherEducationId");

                    b.Property<string>("MatherSpec");

                    b.Property<string>("MotherMobile");

                    b.Property<string>("MotherName");

                    b.Property<int?>("NationalityId");

                    b.Property<string>("Note");

                    b.Property<string>("ParentEmail");

                    b.Property<string>("ParentFace");

                    b.Property<string>("ParentName");

                    b.Property<int?>("ParentRelationId");

                    b.Property<string>("ParentWork");

                    b.Property<int?>("RefugeeCardNo");

                    b.Property<int?>("ReligionId");

                    b.Property<string>("SecondLName");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SmsMobile");

                    b.Property<int?>("SmsParent");

                    b.Property<string>("Street");

                    b.Property<string>("Tel");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("FatherEducationId");

                    b.HasIndex("MatherEducationId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("ParentRelationId");

                    b.HasIndex("ReligionId");

                    b.ToTable("Reg_Parent");
                });

            modelBuilder.Entity("Domain.Model.Reg.RegStud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("BirthPlace");

                    b.Property<string>("DiseaseName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstLName");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<int?>("GenderId");

                    b.Property<int>("IdNum");

                    b.Property<string>("Image");

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<int?>("JoinClassId");

                    b.Property<int?>("JoinClassSeqId");

                    b.Property<int?>("JoinTermId");

                    b.Property<int?>("JoinYearId");

                    b.Property<string>("MedicamentName");

                    b.Property<string>("Note");

                    b.Property<int>("ParentId");

                    b.Property<string>("PreviousSchool");

                    b.Property<int?>("SchoolId");

                    b.Property<int?>("SectionId");

                    b.Property<int?>("StudBrotherSeq");

                    b.Property<string>("StudFace");

                    b.Property<int?>("StudHealthId");

                    b.Property<string>("StudMobile");

                    b.Property<int>("StudNo");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("JoinClassSeqId");

                    b.HasIndex("JoinTermId");

                    b.HasIndex("JoinYearId");

                    b.HasIndex("ParentId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SectionId");

                    b.HasIndex("StudHealthId");

                    b.HasIndex("StudNo")
                        .IsUnique();

                    b.ToTable("Reg_Stud");
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpBus", b =>
                {
                    b.HasOne("Domain.Model.AddLookups.LkpSchool", "LkpSchool")
                        .WithMany("LkpBusses")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpClass", b =>
                {
                    b.HasOne("Domain.Model.AddLookups.LkpSchool", "LkpSchool")
                        .WithMany("LkpClasses")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpSection", "LkpSection")
                        .WithMany("LkpClasses")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "YearsLookup")
                        .WithMany("LkpClasses")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpSchool", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpLookup", "CitesLookup")
                        .WithMany("LkpSchool")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpSection", b =>
                {
                    b.HasOne("Domain.Model.AddLookups.LkpSchool", "LkpSchool")
                        .WithMany("LkpSections")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.AddLookups.LkpTour", b =>
                {
                    b.HasOne("Domain.Model.AddLookups.LkpSchool", "LkpSchool")
                        .WithMany("LkpTours")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.Adm.AdmStud", b =>
                {
                    b.HasOne("Domain.Model.AddLookups.LkpBus", "BusLookup")
                        .WithMany("BusAdmStuds")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpClass", "ClassLookup")
                        .WithMany("ClassAdmStuds")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "DiscountLookup")
                        .WithMany("DiscountAdmMasters")
                        .HasForeignKey("DiscountTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "GenderLookup")
                        .WithMany("GenderAdmMasters")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "NationalityLookup")
                        .WithMany("NationalityAdmMasters")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "ReligionLookup")
                        .WithMany("ReligionAdmMasters")
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpSchool", "LkpSchool")
                        .WithMany("SchoolAdmStuds")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpSection", "LkpSection")
                        .WithMany("SectionAdmStuds")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "SequenceLookup")
                        .WithMany("SequenceAdmMasters")
                        .HasForeignKey("SequenceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpTour", "TourLookup")
                        .WithMany("TourAdmStuds")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "YearLookup")
                        .WithMany("YearAdmMasters")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpCalendar", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpItemCalendar", "LkpItemCalendar")
                        .WithMany("LkpCalendar")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpDocument", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpLookup", "ActiveLookup")
                        .WithMany("ActiveMasters")
                        .HasForeignKey("ActiveId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "DocumentLookup")
                        .WithMany("DocumentMasters")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "MandatoryLookup")
                        .WithMany("MandatoryMasters")
                        .HasForeignKey("MandotoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "SectionLookup")
                        .WithMany("SectionMasters")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpLookup", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpLookupType", "LkpLookupType")
                        .WithMany("LkpLookups")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Model.Reg.RegParent", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpLookup", "CityLookup")
                        .WithMany("CityParents")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "FatherEducationLookup")
                        .WithMany("FatherEducationParents")
                        .HasForeignKey("FatherEducationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "MatherEducationLookup")
                        .WithMany("MatherEducationParents")
                        .HasForeignKey("MatherEducationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "NationalityLookup")
                        .WithMany("NationalityParents")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "ParentRelationLookup")
                        .WithMany("ParentRelationParents")
                        .HasForeignKey("ParentRelationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "ReligionLookup")
                        .WithMany("ReligionParents")
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Model.Reg.RegStud", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpLookup", "GenderLookup")
                        .WithMany("GenderStudMasters")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "JoinClassSeqLookup")
                        .WithMany("JoinClassSeqStudMasters")
                        .HasForeignKey("JoinClassSeqId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "JoinTermLookup")
                        .WithMany("JoinTermStudMasters")
                        .HasForeignKey("JoinTermId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "JoinYearLookup")
                        .WithMany("JoinYearStudMasters")
                        .HasForeignKey("JoinYearId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Reg.RegParent", "RegParent")
                        .WithMany("RegStuds")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpSchool", "LkpSchool")
                        .WithMany("SchoolRegStuds")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpClass", "LkpClass")
                        .WithMany("ClassRegStuds")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.AddLookups.LkpSection", "LkpSection")
                        .WithMany("SectionRegStuds")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Model.Lookups.LkpLookup", "StudHealthLookup")
                        .WithMany("HealthStudMasters")
                        .HasForeignKey("StudHealthId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
