using Microsoft.EntityFrameworkCore.Migrations;

namespace BeluqaTahir.Domain.Migrations
{
    public partial class qwrefhbw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewPassword",
                schema: "Membership",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewPassword",
                schema: "Membership",
                table: "Users");
        }
    }
}
