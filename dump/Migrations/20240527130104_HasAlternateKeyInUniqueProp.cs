using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dump.Migrations
{
    public partial class HasAlternateKeyInUniqueProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Emp_Card",
                table: "Emp",
                column: "Card");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Emp_Card",
                table: "Emp");
        }
    }
}
