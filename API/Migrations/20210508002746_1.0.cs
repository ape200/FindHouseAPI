using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeInfo",
                columns: table => new
                {
                    EId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eno = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EName = table.Column<string>(nullable: true),
                    Sex = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfo", x => x.EId);
                });

            migrationBuilder.CreateTable(
                name: "EmpMenu",
                columns: table => new
                {
                    EMid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eid = table.Column<int>(nullable: false),
                    Mid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpMenu", x => x.EMid);
                });

            migrationBuilder.CreateTable(
                name: "EmpRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RID = table.Column<int>(nullable: false),
                    EID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FristPages",
                columns: table => new
                {
                    F_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hpt_Name = table.Column<string>(nullable: true),
                    Hpt_Image = table.Column<string>(nullable: true),
                    Hpt_Site = table.Column<string>(nullable: true),
                    Hpt_Ara = table.Column<string>(nullable: true),
                    Hpt_Prc = table.Column<string>(nullable: true),
                    Hpt_Sta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FristPages", x => x.F_id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Hid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Hid);
                });

            migrationBuilder.CreateTable(
                name: "MenuInfo",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MName = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    PId = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuInfo", x => x.MId);
                });

            migrationBuilder.CreateTable(
                name: "NewHome",
                columns: table => new
                {
                    HomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeName = table.Column<string>(nullable: true),
                    HomeCharacteristic = table.Column<string>(nullable: true),
                    RealEstate = table.Column<string>(nullable: true),
                    HomeDevelopers = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    HomeDesign = table.Column<string>(nullable: true),
                    HomeIamge = table.Column<string>(nullable: true),
                    HomeArea = table.Column<string>(nullable: true),
                    HomePrice = table.Column<decimal>(nullable: false),
                    HomeMarketType = table.Column<int>(nullable: false),
                    HomeSalesOffice = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: false),
                    Latitude = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewHome", x => x.HomeId);
                });

            migrationBuilder.CreateTable(
                name: "rental",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    proportion = table.Column<string>(nullable: true),
                    charter = table.Column<int>(nullable: false),
                    sort = table.Column<int>(nullable: false),
                    state = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rental", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleInfo",
                columns: table => new
                {
                    RId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RName = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInfo", x => x.RId);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Second_Houses",
                columns: table => new
                {
                    Se_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Se_Name = table.Column<string>(nullable: true),
                    Se_Type = table.Column<string>(nullable: true),
                    Se_YearXian = table.Column<int>(nullable: false),
                    Se_State = table.Column<bool>(nullable: false),
                    Se_SurveyFang = table.Column<string>(nullable: true),
                    Se_SurveyQu = table.Column<string>(nullable: true),
                    Se_ReferencePrice = table.Column<decimal>(nullable: false),
                    Se_HousePrise = table.Column<decimal>(nullable: false),
                    Se_Heat = table.Column<int>(nullable: false),
                    Se_Time = table.Column<DateTime>(nullable: false),
                    Se_Img = table.Column<string>(nullable: true),
                    Se_Area = table.Column<string>(nullable: true),
                    Se_HouesType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Second_Houses", x => x.Se_id);
                });

            migrationBuilder.CreateTable(
                name: "userNew",
                columns: table => new
                {
                    Unid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<int>(nullable: false),
                    Newsid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userNew", x => x.Unid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Gid = table.Column<int>(nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeInfo");

            migrationBuilder.DropTable(
                name: "EmpMenu");

            migrationBuilder.DropTable(
                name: "EmpRole");

            migrationBuilder.DropTable(
                name: "FristPages");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "MenuInfo");

            migrationBuilder.DropTable(
                name: "NewHome");

            migrationBuilder.DropTable(
                name: "rental");

            migrationBuilder.DropTable(
                name: "RoleInfo");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "Second_Houses");

            migrationBuilder.DropTable(
                name: "userNew");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
