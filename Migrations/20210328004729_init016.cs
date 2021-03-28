using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEFC.Migrations
{
    public partial class init016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartList",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartList",
                table: "Users");
        }
    }
}
