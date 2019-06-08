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
    [Migration("20190604112519_LookupTablesV1")]
    partial class LookupTablesV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("LookupName")
                        .IsRequired()
                        .HasMaxLength(200);

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

            modelBuilder.Entity("Domain.Model.Lookups.LkpCalendar", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpItemCalendar", "LkpItemCalendar")
                        .WithMany("LkpCalendar")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpLookup", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpLookupType", "LkpLookupType")
                        .WithMany("LkpLookups")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
