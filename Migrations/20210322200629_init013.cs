using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEFC.Migrations
{
    public partial class init013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EmailWasConfirmed",
                table: "ClientsInfo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailWasConfirmed",
                table: "ClientsInfo");
        }
    }
}
