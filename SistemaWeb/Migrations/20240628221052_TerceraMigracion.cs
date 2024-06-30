using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaWeb.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Hasta",
                table: "Alquilers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Desde",
                table: "Alquilers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Hasta",
                table: "Alquilers",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Desde",
                table: "Alquilers",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }
    }
}
