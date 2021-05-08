using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Se_ReferencePrice",
            //    table: "Second_Houses",
            //    nullable: false,
            //    oldClrType: typeof(double),
            //    oldType: "float");

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "Se_HousePrise",
            //    table: "Second_Houses",
            //    nullable: false,
            //    oldClrType: typeof(double),
            //    oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Se_ReferencePrice",
                table: "Second_Houses",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "Se_HousePrise",
                table: "Second_Houses",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
