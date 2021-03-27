using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEFC.Migrations
{
    public partial class init015 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Count",
                table: "Items",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Items",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Items");
        }
    }
}
