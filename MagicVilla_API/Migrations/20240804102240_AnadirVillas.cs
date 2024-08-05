using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AnadirVillas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenURL", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Explicación de la villa", new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3466), "", 120, "Villa Real", 5, 120.0 },
                    { 2, "", "Explicación de la degunda", new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3522), new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3521), "", 110, "Villa Segunda", 3, 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
