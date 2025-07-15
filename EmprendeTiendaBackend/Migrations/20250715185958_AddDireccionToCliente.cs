using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprendeTiendaBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddDireccionToCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Direccion",
                value: "Calle Falsa 123");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Direccion",
                value: "Avenida Siempre Viva 456");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Direccion",
                value: "Boulevard de los Sueños Rotos 789");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 7, 10, 15, 59, 57, 877, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 7, 12, 15, 59, 57, 877, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 7, 14, 15, 59, 57, 877, DateTimeKind.Local).AddTicks(1838));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 6, 21, 23, 22, 13, 696, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 6, 23, 23, 22, 13, 696, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 6, 25, 23, 22, 13, 696, DateTimeKind.Local).AddTicks(6823));
        }
    }
}
