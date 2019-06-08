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
    [Migration("20190603082237_LkpCalendar")]
    partial class LkpCalendar
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

                    b.Property<int?>("LkpItemCalendarId");

                    b.Property<string>("Note");

                    b.Property<int>("SectionId");

                    b.Property<DateTime>("ToDate");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<int?>("UpdateUser");

                    b.Property<int>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("LkpItemCalendarId");

                    b.ToTable("LkpCalendar");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpItemCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("InsertDate");

                    b.Property<int?>("InsertUser");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<int?>("UpdateUser");

                    b.HasKey("Id");

                    b.ToTable("LkpItemCalendar");
                });

            modelBuilder.Entity("Domain.Model.Lookups.LkpCalendar", b =>
                {
                    b.HasOne("Domain.Model.Lookups.LkpItemCalendar", "LkpItemCalendar")
                        .WithMany("LkpCalendar")
                        .HasForeignKey("LkpItemCalendarId");
                });
#pragma warning restore 612, 618
        }
    }
}