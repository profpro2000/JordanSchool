using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class financeYaseenV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ArName = table.Column<string>(nullable: true),
                    LaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Item_Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Item_Calendar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Lookup_Type",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Editable = table.Column<int>(maxLength: 1, nullable: true),
                    Code = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Lookup_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Year",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AName = table.Column<string>(maxLength: 200, nullable: false),
                    LName = table.Column<string>(nullable: true),
                    Active = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Year", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: true),
                    CurrentUrl = table.Column<string>(nullable: true),
                    IsSuperAdmin = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Calendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Calendar_Lkp_Item_Calendar_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Lkp_Item_Calendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    AName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    DefaultValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Lookup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Lookup_Lkp_Lookup_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Lkp_Lookup_Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fin_items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ArDesc = table.Column<string>(nullable: true),
                    LaDesc = table.Column<string>(nullable: true),
                    cdTypeId = table.Column<int>(nullable: false),
                    vpTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fin_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fin_items_Lkp_Lookup_cdTypeId",
                        column: x => x.cdTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fin_items_Lkp_Lookup_vpTypeId",
                        column: x => x.vpTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_School",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Aname = table.Column<string>(maxLength: 100, nullable: false),
                    Lname = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    WebPage = table.Column<string>(nullable: true),
                    FaceBook = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_School", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_School_Lkp_Lookup_CityId",
                        column: x => x.CityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reg_Parent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdNum = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    SecondName = table.Column<string>(maxLength: 100, nullable: false),
                    FamilyName = table.Column<string>(maxLength: 100, nullable: false),
                    FirstLName = table.Column<string>(nullable: true),
                    SecondLName = table.Column<string>(nullable: true),
                    FamilyLName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Locality1 = table.Column<string>(nullable: true),
                    Locality2 = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    BuildingNo = table.Column<string>(nullable: true),
                    FatherEducationId = table.Column<int>(nullable: true),
                    FatherSpec = table.Column<string>(nullable: true),
                    MatherEducationId = table.Column<int>(nullable: true),
                    MatherSpec = table.Column<string>(nullable: true),
                    ParentRelationId = table.Column<int>(nullable: true),
                    ParentName = table.Column<string>(nullable: true),
                    ParentWork = table.Column<string>(nullable: true),
                    FamilySize = table.Column<int>(nullable: true),
                    FamilyIncome = table.Column<int>(nullable: true),
                    FamilyAssistance = table.Column<string>(nullable: true),
                    RefugeeCardNo = table.Column<int>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    FatherMobile = table.Column<string>(nullable: true),
                    MotherMobile = table.Column<string>(nullable: true),
                    SmsParent = table.Column<int>(nullable: true),
                    SmsMobile = table.Column<string>(nullable: true),
                    ParentEmail = table.Column<string>(nullable: true),
                    ParentFace = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reg_Parent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_CityId",
                        column: x => x.CityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_FatherEducationId",
                        column: x => x.FatherEducationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_MatherEducationId",
                        column: x => x.MatherEducationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_ParentRelationId",
                        column: x => x.ParentRelationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Bus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SidNo = table.Column<string>(maxLength: 100, nullable: false),
                    DriverName = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    MorningSuper = table.Column<string>(nullable: true),
                    EvningSuper = table.Column<string>(maxLength: 100, nullable: true),
                    SchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Bus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Bus_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Section",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SectionName = table.Column<string>(maxLength: 120, nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NationalId = table.Column<string>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Section_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LkpTour",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    TourName = table.Column<string>(maxLength: 200, nullable: false),
                    TourFullPrice = table.Column<int>(nullable: false, defaultValue: 0),
                    TourHalfPrice = table.Column<int>(nullable: false, defaultValue: 0),
                    SchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LkpTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LkpTour_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "School_Fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    FinItemId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_School_Fees_Fin_items_FinItemId",
                        column: x => x.FinItemId,
                        principalTable: "Fin_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_School_Fees_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_School_Fees_Lkp_Year_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Year",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sys_UserSchool",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_UserSchool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_UserSchool_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sys_UserSchool_Sys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Sys_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RegParentId = table.Column<int>(nullable: false),
                    VoucherId = table.Column<string>(nullable: true),
                    VoucherDate = table.Column<DateTime>(nullable: false),
                    VoucherTypeId = table.Column<int>(nullable: false),
                    VoucherStatusId = table.Column<int>(nullable: false),
                    Debit = table.Column<int>(nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Reg_Parent_RegParentId",
                        column: x => x.RegParentId,
                        principalTable: "Reg_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Lkp_Lookup_VoucherStatusId",
                        column: x => x.VoucherStatusId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Lkp_Lookup_VoucherTypeId",
                        column: x => x.VoucherTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Aname = table.Column<string>(maxLength: 100, nullable: false),
                    Lname = table.Column<string>(maxLength: 100, nullable: true),
                    Amt = table.Column<int>(maxLength: 10, nullable: false, defaultValue: 0),
                    Capacity = table.Column<int>(maxLength: 3, nullable: false, defaultValue: 0),
                    Age = table.Column<float>(maxLength: 2, nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    LkpLookupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_Lookup_LkpLookupId",
                        column: x => x.LkpLookupId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_Year_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Year",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adm_Stud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    StudNo = table.Column<int>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    GenderId = table.Column<int>(nullable: true),
                    YearId = table.Column<int>(nullable: true),
                    ClassId = table.Column<int>(nullable: true),
                    ClassPrice = table.Column<int>(nullable: false),
                    ClassSeqId = table.Column<int>(nullable: true),
                    TourId = table.Column<int>(nullable: true),
                    TourTypeId = table.Column<int>(nullable: true),
                    BusId = table.Column<int>(nullable: true),
                    TourPrice = table.Column<int>(nullable: true),
                    ApprovedId = table.Column<int>(nullable: true),
                    ApprovedDate = table.Column<DateTime>(nullable: true),
                    StudentBrotherSeq = table.Column<int>(nullable: true),
                    BrotherDescountType = table.Column<int>(nullable: true),
                    BusNote = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    IdNum = table.Column<int>(nullable: true),
                    FirstLName = table.Column<string>(nullable: true),
                    StudMobile = table.Column<string>(nullable: true),
                    PreviousSchool = table.Column<string>(nullable: true),
                    JoinYearId = table.Column<int>(nullable: true),
                    JoinTermId = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StudFace = table.Column<string>(nullable: true),
                    StudBrotherSeq = table.Column<int>(nullable: true),
                    StudHealthId = table.Column<int>(nullable: true),
                    DiseaseName = table.Column<string>(nullable: true),
                    MedicamentName = table.Column<string>(nullable: true),
                    LkpLookupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_Stud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_ApprovedId",
                        column: x => x.ApprovedId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Bus_BusId",
                        column: x => x.BusId,
                        principalTable: "Lkp_Bus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_ClassSeqId",
                        column: x => x.ClassSeqId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_JoinTermId",
                        column: x => x.JoinTermId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_JoinYearId",
                        column: x => x.JoinYearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_LkpLookupId",
                        column: x => x.LkpLookupId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Reg_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Reg_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_StudHealthId",
                        column: x => x.StudHealthId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_LkpTour_TourId",
                        column: x => x.TourId,
                        principalTable: "LkpTour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_TourTypeId",
                        column: x => x.TourTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class_fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    FinItemId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_fees_Lkp_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_fees_Fin_items_FinItemId",
                        column: x => x.FinItemId,
                        principalTable: "Fin_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_fees_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_fees_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reg_Stud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    StudNo = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    IdNum = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 75, nullable: false),
                    FirstLName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: true),
                    StudMobile = table.Column<string>(nullable: true),
                    PreviousSchool = table.Column<string>(nullable: true),
                    JoinYearId = table.Column<int>(nullable: true),
                    JoinTermId = table.Column<int>(nullable: true),
                    SchoolId = table.Column<int>(nullable: true),
                    SectionId = table.Column<int>(nullable: true),
                    JoinClassId = table.Column<int>(nullable: true),
                    JoinClassSeqId = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StudFace = table.Column<string>(nullable: true),
                    StudBrotherSeq = table.Column<int>(nullable: true),
                    StudHealthId = table.Column<int>(nullable: true),
                    DiseaseName = table.Column<string>(nullable: true),
                    MedicamentName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reg_Stud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_JoinClassSeqId",
                        column: x => x.JoinClassSeqId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_JoinTermId",
                        column: x => x.JoinTermId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_JoinYearId",
                        column: x => x.JoinYearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Reg_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Reg_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Class_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_StudHealthId",
                        column: x => x.StudHealthId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student_fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    FinItemId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    PaymentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_fees_Fin_items_FinItemId",
                        column: x => x.FinItemId,
                        principalTable: "Fin_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_fees_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_fees_Reg_Stud_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Reg_Stud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_fees_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ApprovedId",
                table: "Adm_Stud",
                column: "ApprovedId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_BusId",
                table: "Adm_Stud",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ClassId",
                table: "Adm_Stud",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ClassSeqId",
                table: "Adm_Stud",
                column: "ClassSeqId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_GenderId",
                table: "Adm_Stud",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_JoinTermId",
                table: "Adm_Stud",
                column: "JoinTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_JoinYearId",
                table: "Adm_Stud",
                column: "JoinYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_LkpLookupId",
                table: "Adm_Stud",
                column: "LkpLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_NationalityId",
                table: "Adm_Stud",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ParentId",
                table: "Adm_Stud",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ReligionId",
                table: "Adm_Stud",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_SchoolId",
                table: "Adm_Stud",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_SectionId",
                table: "Adm_Stud",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_StudHealthId",
                table: "Adm_Stud",
                column: "StudHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_TourId",
                table: "Adm_Stud",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_TourTypeId",
                table: "Adm_Stud",
                column: "TourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_YearId",
                table: "Adm_Stud",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_ClassId",
                table: "Class_fees",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_FinItemId",
                table: "Class_fees",
                column: "FinItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_SectionId",
                table: "Class_fees",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_YearId",
                table: "Class_fees",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Fin_items_cdTypeId",
                table: "Fin_items",
                column: "cdTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fin_items_vpTypeId",
                table: "Fin_items",
                column: "vpTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Bus_SchoolId",
                table: "Lkp_Bus",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Calendar_ItemId",
                table: "Lkp_Calendar",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_LkpLookupId",
                table: "Lkp_Class",
                column: "LkpLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_SchoolId",
                table: "Lkp_Class",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_SectionId",
                table: "Lkp_Class",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_YearId",
                table: "Lkp_Class",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Lookup_TypeId",
                table: "Lkp_Lookup",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_School_CityId",
                table: "Lkp_School",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Section_SchoolId",
                table: "Lkp_Section",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_LkpTour_SchoolId",
                table: "LkpTour",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RegParentId",
                table: "Payments",
                column: "RegParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VoucherStatusId",
                table: "Payments",
                column: "VoucherStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VoucherTypeId",
                table: "Payments",
                column: "VoucherTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_CityId",
                table: "Reg_Parent",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_FatherEducationId",
                table: "Reg_Parent",
                column: "FatherEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_MatherEducationId",
                table: "Reg_Parent",
                column: "MatherEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_NationalityId",
                table: "Reg_Parent",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_ParentRelationId",
                table: "Reg_Parent",
                column: "ParentRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_ReligionId",
                table: "Reg_Parent",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_GenderId",
                table: "Reg_Stud",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_JoinClassSeqId",
                table: "Reg_Stud",
                column: "JoinClassSeqId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_JoinTermId",
                table: "Reg_Stud",
                column: "JoinTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_JoinYearId",
                table: "Reg_Stud",
                column: "JoinYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_ParentId",
                table: "Reg_Stud",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_SchoolId",
                table: "Reg_Stud",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_SectionId",
                table: "Reg_Stud",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_StudHealthId",
                table: "Reg_Stud",
                column: "StudHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_StudNo",
                table: "Reg_Stud",
                column: "StudNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_School_Fees_FinItemId",
                table: "School_Fees",
                column: "FinItemId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fees_SchoolId",
                table: "School_Fees",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fees_YearId",
                table: "School_Fees",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_FinItemId",
                table: "Student_fees",
                column: "FinItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_PaymentId",
                table: "Student_fees",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_StudentId",
                table: "Student_fees",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_YearId",
                table: "Student_fees",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Users_Username",
                table: "Sys_Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserSchool_SchoolId",
                table: "Sys_UserSchool",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserSchool_UserId",
                table: "Sys_UserSchool",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adm_Stud");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Class_fees");

            migrationBuilder.DropTable(
                name: "Lkp_Calendar");

            migrationBuilder.DropTable(
                name: "School_Fees");

            migrationBuilder.DropTable(
                name: "Student_fees");

            migrationBuilder.DropTable(
                name: "Sys_UserSchool");

            migrationBuilder.DropTable(
                name: "Lkp_Bus");

            migrationBuilder.DropTable(
                name: "LkpTour");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Lkp_Item_Calendar");

            migrationBuilder.DropTable(
                name: "Fin_items");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reg_Stud");

            migrationBuilder.DropTable(
                name: "Sys_Users");

            migrationBuilder.DropTable(
                name: "Reg_Parent");

            migrationBuilder.DropTable(
                name: "Lkp_Class");

            migrationBuilder.DropTable(
                name: "Lkp_Section");

            migrationBuilder.DropTable(
                name: "Lkp_Year");

            migrationBuilder.DropTable(
                name: "Lkp_School");

            migrationBuilder.DropTable(
                name: "Lkp_Lookup");

            migrationBuilder.DropTable(
                name: "Lkp_Lookup_Type");
        }
    }
}
