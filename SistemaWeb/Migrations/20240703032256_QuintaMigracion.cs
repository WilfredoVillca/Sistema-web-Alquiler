using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaWeb.Migrations
{
    /// <inheritdoc />
    public partial class QuintaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Esta_Ocupado",
                table: "Canchas");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Alquilers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Alquilers");

            migrationBuilder.AddColumn<bool>(
                name: "Esta_Ocupado",
                table: "Canchas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
