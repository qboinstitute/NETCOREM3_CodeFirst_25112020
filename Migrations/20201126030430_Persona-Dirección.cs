using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCOREM3_CodeFirst.Migrations
{
    public partial class PersonaDirección : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "Personas",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "direccion",
                table: "Personas");
        }
    }
}
