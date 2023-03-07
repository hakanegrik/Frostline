using Microsoft.EntityFrameworkCore.Migrations;

namespace FrostlineECommerce.App.DataAccess.Migrations
{
    public partial class FECMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Discount",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PeriodName",
                table: "Discount",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "PeriodName",
                table: "Discount");
        }
    }
}
