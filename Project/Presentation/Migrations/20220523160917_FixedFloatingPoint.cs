using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class FixedFloatingPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotel",
                type: "decimal(18,15)",
                precision: 18,
                scale: 15,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotel",
                type: "decimal(18,15)",
                precision: 18,
                scale: 15,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.308648751688416m, 23.83565425872803m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.308648751688416m, 23.83565425872803m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("37bee21f-8041-4b61-aee9-06836f247e87"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.308648751688416m, 23.83565425872803m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.308648751688416m, 23.83565425872803m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("cb0ed9a2-7065-4cbe-b925-473053419a0f"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.308648751688416m, 23.83565425872803m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.308648751688416m, 23.83565425872803m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotel",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,15)",
                oldPrecision: 18,
                oldScale: 15);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotel",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,15)",
                oldPrecision: 18,
                oldScale: 15);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.31m, 23.84m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.31m, 23.84m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("37bee21f-8041-4b61-aee9-06836f247e87"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.31m, 23.84m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.31m, 23.84m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("cb0ed9a2-7065-4cbe-b925-473053419a0f"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.31m, 23.84m });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"),
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.31m, 23.84m });
        }
    }
}
