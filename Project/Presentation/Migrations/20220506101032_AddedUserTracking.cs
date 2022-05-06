using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class AddedUserTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Hotel_HotelId",
                table: "Occupation");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropIndex(
                name: "IX_Occupation_HotelId",
                table: "Occupation");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"));

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Occupation");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "HotelPicture",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                table: "HotelPicture",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"),
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "IsDeleted", "Latitude", "Longitude", "ModifiedAt", "ModifiedById", "Name", "Quality", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("37bee21f-8041-4b61-aee9-06836f247e87"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FFFF", false, 44.31m, 23.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "fff", 1, "FF" },
                    { new Guid("cb0ed9a2-7065-4cbe-b925-473053419a0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EEEE", false, 44.31m, 23.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eee", 1, "EE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelPicture_CreatedById",
                table: "HotelPicture",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_HotelPicture_ModifiedById",
                table: "HotelPicture",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPicture_AspNetUsers_CreatedById",
                table: "HotelPicture",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPicture_AspNetUsers_ModifiedById",
                table: "HotelPicture",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelPicture_AspNetUsers_CreatedById",
                table: "HotelPicture");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPicture_AspNetUsers_ModifiedById",
                table: "HotelPicture");

            migrationBuilder.DropIndex(
                name: "IX_HotelPicture_CreatedById",
                table: "HotelPicture");

            migrationBuilder.DropIndex(
                name: "IX_HotelPicture_ModifiedById",
                table: "HotelPicture");

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("37bee21f-8041-4b61-aee9-06836f247e87"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("cb0ed9a2-7065-4cbe-b925-473053419a0f"));

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "HotelPicture");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "HotelPicture");

            migrationBuilder.AddColumn<Guid>(
                name: "HotelId",
                table: "Occupation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedAt", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PictureId", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"), 0, "6ab0c402-4f2a-49d8-a6dc-0979470154da", new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1445), new DateTime(2004, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1499), "georgegeorge@george.com", false, 4, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", null, null, null, "0767676767", null, false, null, null, "George", false, null });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"),
                column: "CreatedAt",
                value: new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ae70e13-c702-451b-8f46-cfeba46708a5", "1", "Administrator", "Admin" },
                    { "d2361beb-bde5-4c35-a82f-b0629951ab76", "2", "User", "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Occupation_HotelId",
                table: "Occupation",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Hotel_HotelId",
                table: "Occupation",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id");
        }
    }
}
