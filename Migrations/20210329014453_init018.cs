using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEFC.Migrations
{
    public partial class init018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartList",
                table: "ClientsInfo",
                newName: "CartListItems");

            migrationBuilder.AddColumn<string>(
                name: "CartInfo",
                table: "ClientsInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartInfo",
                table: "ClientsInfo");

            migrationBuilder.RenameColumn(
                name: "CartListItems",
                table: "ClientsInfo",
                newName: "CartList");
        }
    }
}
