using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dump.Migrations
{
    public partial class EditForFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Fluent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Fluent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Fluent");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Fluent");
        }
    }
}
