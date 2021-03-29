using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEFC.Migrations
{
    public partial class init017 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartList",
                table: "ClientsInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartList",
                table: "ClientsInfo");
        }
    }
}
