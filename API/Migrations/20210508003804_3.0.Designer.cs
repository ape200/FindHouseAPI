// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(HouseContext))]
    [Migration("20210508003804_3.0")]
    partial class _30
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.EmpMenu", b =>
                {
                    b.Property<int>("EMid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Eid")
                        .HasColumnType("int");

                    b.Property<int>("Mid")
                        .HasColumnType("int");

                    b.HasKey("EMid");

                    b.ToTable("EmpMenu");
                });

            modelBuilder.Entity("API.Models.EmpRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EID")
                        .HasColumnType("int");

                    b.Property<int>("RID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmpRole");
                });

            modelBuilder.Entity("API.Models.EmployeeInfo", b =>
                {
                    b.Property<int>("EId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("EId");

                    b.ToTable("EmployeeInfo");
                });

            modelBuilder.Entity("API.Models.FristPage", b =>
                {
                    b.Property<int>("F_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hpt_Ara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hpt_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hpt_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hpt_Prc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hpt_Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hpt_Sta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("F_id");

                    b.ToTable("FristPages");
                });

            modelBuilder.Entity("API.Models.House", b =>
                {
                    b.Property<int>("Hid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Hid");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("API.Models.MenuInfo", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MId");

                    b.ToTable("MenuInfo");
                });

            modelBuilder.Entity("API.Models.NewHome", b =>
                {
                    b.Property<int>("HomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeCharacteristic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeDesign")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeDevelopers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeIamge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeMarketType")
                        .HasColumnType("int");

                    b.Property<string>("HomeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HomePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HomeSalesOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RealEstate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomeId");

                    b.ToTable("NewHome");
                });

            modelBuilder.Entity("API.Models.RoleInfo", b =>
                {
                    b.Property<int>("RId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("RName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RId");

                    b.ToTable("RoleInfo");
                });

            modelBuilder.Entity("API.Models.RoleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<int>("RId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoleMenu");
                });

            modelBuilder.Entity("API.Models.Second_House", b =>
                {
                    b.Property<int>("Se_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Se_Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Se_Heat")
                        .HasColumnType("int");

                    b.Property<string>("Se_HouesType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Se_HousePrise")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Se_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Se_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Se_ReferencePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Se_State")
                        .HasColumnType("bit");

                    b.Property<string>("Se_SurveyFang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Se_SurveyQu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Se_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Se_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Se_YearXian")
                        .HasColumnType("int");

                    b.HasKey("Se_id");

                    b.ToTable("Second_Houses");
                });

            modelBuilder.Entity("API.Models.rental", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("charter")
                        .HasColumnType("int");

                    b.Property<string>("proportion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sort")
                        .HasColumnType("int");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("rental");
                });

            modelBuilder.Entity("API.Models.userNew", b =>
                {
                    b.Property<int>("Unid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Newsid")
                        .HasColumnType("int");

                    b.Property<int>("Userid")
                        .HasColumnType("int");

                    b.HasKey("Unid");

                    b.ToTable("userNew");
                });

            modelBuilder.Entity("API.Models.users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
