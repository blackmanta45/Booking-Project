using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class AddedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_User_UserId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_User_CreatedById",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_User_ModifiedById",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_User_CreatedById",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_User_ModifiedById",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_User_CreatedById",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_User_ModifiedById",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_User_CreatedById",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_User_ModifiedById",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomPrice_User_CreatedById",
                table: "RoomPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomPrice_User_ModifiedById",
                table: "RoomPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserPicture_PictureId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("041d0961-3007-46f4-8413-56f25fef7b37"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("10c1eecc-c70d-4503-b958-07bab7526f2c"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("20491b51-d345-4bf8-95d3-cad141927df1"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("30cd9926-edd8-4542-a8c1-e065b07dcb0a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3ad827e5-198a-40b7-811f-1ce64d3c8ebf"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3c243dd1-a0e7-431f-b4fb-9ac5ea5b61bb"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("4733b2d2-26aa-450d-a2e5-92aa6af1fba9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("4db81cc8-5aec-4a5a-82f3-bfdf48c5cbe8"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("6042f260-5aee-4ec8-9500-11badece9236"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("72ae754e-fa14-4a5b-9361-d8107f239082"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("79ae0a49-0cb2-4786-85c7-b91fe5adb786"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7d5eb0b9-8100-46dc-a622-d2d2fc650188"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("96ebf603-bf3a-498b-8d22-61239e1be33e"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("9bb72415-62d6-4fc6-8ea7-b75c4bdd2f16"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("a6c5fd97-9da3-4b8b-9a22-deebfd9cdcc1"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("a7a39eb9-2857-49f5-a682-42ac8c2c4292"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("abb39912-da95-4a90-8c4f-5fb006ead2a1"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b374f9cc-c678-4766-93f4-5564d49a1c09"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b4693c09-8512-47e6-96d9-e27a476fd351"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b799635f-b1e7-44dd-a2d3-447adb86b19d"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b89c7fdb-64c4-4e33-91fa-f5c7e6fa5834"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("bbdeeb89-c879-40e0-81c6-c9c6559ef5e9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("bf5bb3cf-beb8-4dc6-848d-88c84d8765af"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c09480d3-60ba-45c5-9ed9-263210ef4038"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("d134793c-f031-42e1-a013-00aec8883df9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("d254745f-af67-4a42-8b3a-a676a1990f23"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("da389746-ff89-40dc-9201-88004508c3c5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e81b7d40-f52a-4f92-b4df-3ef19f39f6d7"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("f805858a-e5b6-44db-8eed-28214c5cc097"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("f92c7814-5a71-4f79-86b6-214fa1a45ad3"));

            migrationBuilder.RenameTable(
                name: "User",
                newName: "AspNetUsers");

            migrationBuilder.RenameIndex(
                name: "IX_User_PictureId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_PictureId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedAt", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PictureId", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"), 0, "6ab0c402-4f2a-49d8-a6dc-0979470154da", new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1445), new DateTime(2004, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1499), "georgegeorge@george.com", false, 4, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", null, null, null, "0767676767", null, false, null, null, "George", false, null });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "IsDeleted", "Latitude", "Longitude", "ModifiedAt", "ModifiedById", "Name", "Quality", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"), new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1541), null, "CCCC", false, 44.31m, 23.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ccc", 2, "CC" },
                    { new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"), new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1544), null, "DDDD", false, 44.31m, 23.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ddd", 1, "DD" },
                    { new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6"), new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1524), null, "AAAA", false, 46m, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "aaa", 5, "AA" },
                    { new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"), new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1531), null, "BBBB", false, 44.31m, 23.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bbb", 4, "BB" },
                    { new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"), new DateTime(2022, 5, 3, 16, 30, 38, 886, DateTimeKind.Local).AddTicks(1537), null, "BBBB", false, 44.31m, 23.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bbb", 3, "BB" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ae70e13-c702-451b-8f46-cfeba46708a5", "1", "Administrator", "Admin" },
                    { "d2361beb-bde5-4c35-a82f-b0629951ab76", "2", "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "DefaultPrice", "People", "Stars" },
                values: new object[,]
                {
                    { new Guid("1e10ce12-421f-411b-9673-cc9b745458a5"), 500m, 6, 3 },
                    { new Guid("21e49e4c-73be-43db-8ab2-4cffa4b7ffd9"), 375m, 4, 3 },
                    { new Guid("254c2247-fc55-40b7-9e37-e2a8ca0853ab"), 500m, 1, 5 },
                    { new Guid("3ae180cb-6baa-46e9-b246-320436538be2"), 650m, 5, 5 },
                    { new Guid("523c3d94-887d-40b0-a31a-dfd2273ebc61"), 450m, 5, 3 },
                    { new Guid("5883f53b-0dc8-4fb3-b0b0-702742ab836b"), 250m, 5, 1 },
                    { new Guid("5ac314fa-b312-403b-a1bb-63fe7a28250c"), 600m, 6, 4 },
                    { new Guid("5cfdeff2-dd9d-4bce-a6ca-bc9d386a3765"), 550m, 5, 4 },
                    { new Guid("5dfa4292-8bff-4710-9253-b0dddd97f687"), 400m, 6, 2 },
                    { new Guid("6b851411-60ea-4f29-ab6e-431006c056fb"), 100m, 2, 1 },
                    { new Guid("7fba7445-fd81-4e16-bd27-e05f53a830f4"), 300m, 1, 3 },
                    { new Guid("80f76308-a398-438a-b155-b4bc8a196620"), 475m, 4, 4 },
                    { new Guid("81a63fab-a7d8-4236-aa08-411988901b92"), 500m, 2, 5 },
                    { new Guid("854a3dd6-cfc7-4cae-805b-ec16956c3b80"), 200m, 1, 2 },
                    { new Guid("86c9336f-8887-4efa-a9c8-afcb29a8b9e9"), 300m, 2, 3 },
                    { new Guid("89307e4d-c8b6-43c2-a495-7623ed9e58c6"), 275m, 4, 2 },
                    { new Guid("8db8586d-c284-44a9-9a3b-f789810d84e5"), 400m, 2, 4 },
                    { new Guid("94cb77a0-48a3-4dc7-bdb2-4119ff66e66e"), 140m, 3, 1 },
                    { new Guid("9aef0aa4-c0b0-4e8e-b4a2-a1c03bddd105"), 440m, 3, 4 },
                    { new Guid("9d56ebc4-aff9-4b3a-a4b3-68f26bedc756"), 575m, 4, 5 },
                    { new Guid("b73ed71b-a736-4428-88bc-bf1526262430"), 175m, 4, 1 },
                    { new Guid("bb3e5a25-d7ec-4da3-baf0-b7e52476d542"), 400m, 1, 4 },
                    { new Guid("c5c8778a-0e36-4e8a-bf9d-68aeef0ddd33"), 540m, 3, 5 },
                    { new Guid("cb9804e5-8db6-40c0-98fd-00bdda8d97a4"), 700m, 6, 5 },
                    { new Guid("cc313a09-2902-4c9b-b5a2-6910810a843c"), 240m, 3, 2 },
                    { new Guid("d4ae2886-2cd6-480e-9c41-52c7295c4756"), 100m, 1, 1 },
                    { new Guid("dbb65294-0250-4cfa-921b-14bbbab5167e"), 350m, 5, 2 },
                    { new Guid("ddfd646e-057f-4a10-afbb-2aa79eea92b4"), 340m, 3, 3 },
                    { new Guid("df7f20c3-852b-4582-90a0-c9f79247bd63"), 300m, 6, 1 },
                    { new Guid("e3c73520-cbaf-46b9-88fc-12787f5921e4"), 200m, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserPicture_PictureId",
                table: "AspNetUsers",
                column: "PictureId",
                principalTable: "UserPicture",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_History_AspNetUsers_UserId",
                table: "History",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_AspNetUsers_CreatedById",
                table: "Hotel",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_AspNetUsers_ModifiedById",
                table: "Hotel",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_AspNetUsers_CreatedById",
                table: "Occupation",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_AspNetUsers_ModifiedById",
                table: "Occupation",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_AspNetUsers_CreatedById",
                table: "Picture",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_AspNetUsers_ModifiedById",
                table: "Picture",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_AspNetUsers_CreatedById",
                table: "Room",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_AspNetUsers_ModifiedById",
                table: "Room",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomPrice_AspNetUsers_CreatedById",
                table: "RoomPrice",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomPrice_AspNetUsers_ModifiedById",
                table: "RoomPrice",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserPicture_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_History_AspNetUsers_UserId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_AspNetUsers_CreatedById",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_AspNetUsers_ModifiedById",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_AspNetUsers_CreatedById",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_AspNetUsers_ModifiedById",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_AspNetUsers_CreatedById",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_AspNetUsers_ModifiedById",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_AspNetUsers_CreatedById",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_AspNetUsers_ModifiedById",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomPrice_AspNetUsers_CreatedById",
                table: "RoomPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomPrice_AspNetUsers_ModifiedById",
                table: "RoomPrice");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ac365e29-7f22-472f-bd22-ce7fab2e48f2"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("048b1f87-b7c9-4ccf-af0f-5cb29ddebc78"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("2f2fe0de-d277-4852-8fb4-2dceac60a5fd"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("3bbd424c-ecb4-45b0-9aa5-07f7b983e9e6"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("b8dc0bdc-fda1-4e21-b485-8d88308f3bbe"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("dfe5b40c-0a3d-4ee9-8898-a80bcb1d584c"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1e10ce12-421f-411b-9673-cc9b745458a5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("21e49e4c-73be-43db-8ab2-4cffa4b7ffd9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("254c2247-fc55-40b7-9e37-e2a8ca0853ab"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3ae180cb-6baa-46e9-b246-320436538be2"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("523c3d94-887d-40b0-a31a-dfd2273ebc61"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5883f53b-0dc8-4fb3-b0b0-702742ab836b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5ac314fa-b312-403b-a1bb-63fe7a28250c"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5cfdeff2-dd9d-4bce-a6ca-bc9d386a3765"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5dfa4292-8bff-4710-9253-b0dddd97f687"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("6b851411-60ea-4f29-ab6e-431006c056fb"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7fba7445-fd81-4e16-bd27-e05f53a830f4"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("80f76308-a398-438a-b155-b4bc8a196620"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("81a63fab-a7d8-4236-aa08-411988901b92"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("854a3dd6-cfc7-4cae-805b-ec16956c3b80"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("86c9336f-8887-4efa-a9c8-afcb29a8b9e9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("89307e4d-c8b6-43c2-a495-7623ed9e58c6"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("8db8586d-c284-44a9-9a3b-f789810d84e5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("94cb77a0-48a3-4dc7-bdb2-4119ff66e66e"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("9aef0aa4-c0b0-4e8e-b4a2-a1c03bddd105"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("9d56ebc4-aff9-4b3a-a4b3-68f26bedc756"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b73ed71b-a736-4428-88bc-bf1526262430"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("bb3e5a25-d7ec-4da3-baf0-b7e52476d542"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c5c8778a-0e36-4e8a-bf9d-68aeef0ddd33"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("cb9804e5-8db6-40c0-98fd-00bdda8d97a4"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("cc313a09-2902-4c9b-b5a2-6910810a843c"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("d4ae2886-2cd6-480e-9c41-52c7295c4756"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("dbb65294-0250-4cfa-921b-14bbbab5167e"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("ddfd646e-057f-4a10-afbb-2aa79eea92b4"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("df7f20c3-852b-4582-90a0-c9f79247bd63"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e3c73520-cbaf-46b9-88fc-12787f5921e4"));

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "User",
                newName: "IX_User_PictureId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "DefaultPrice", "People", "Stars" },
                values: new object[,]
                {
                    { new Guid("041d0961-3007-46f4-8413-56f25fef7b37"), 350m, 5, 2 },
                    { new Guid("10c1eecc-c70d-4503-b958-07bab7526f2c"), 400m, 2, 4 },
                    { new Guid("20491b51-d345-4bf8-95d3-cad141927df1"), 500m, 1, 5 },
                    { new Guid("30cd9926-edd8-4542-a8c1-e065b07dcb0a"), 450m, 5, 3 },
                    { new Guid("3ad827e5-198a-40b7-811f-1ce64d3c8ebf"), 250m, 5, 1 },
                    { new Guid("3c243dd1-a0e7-431f-b4fb-9ac5ea5b61bb"), 500m, 6, 3 },
                    { new Guid("4733b2d2-26aa-450d-a2e5-92aa6af1fba9"), 650m, 5, 5 },
                    { new Guid("4db81cc8-5aec-4a5a-82f3-bfdf48c5cbe8"), 700m, 6, 5 },
                    { new Guid("6042f260-5aee-4ec8-9500-11badece9236"), 140m, 3, 1 },
                    { new Guid("72ae754e-fa14-4a5b-9361-d8107f239082"), 175m, 4, 1 },
                    { new Guid("79ae0a49-0cb2-4786-85c7-b91fe5adb786"), 550m, 5, 4 },
                    { new Guid("7d5eb0b9-8100-46dc-a622-d2d2fc650188"), 440m, 3, 4 },
                    { new Guid("96ebf603-bf3a-498b-8d22-61239e1be33e"), 375m, 4, 3 },
                    { new Guid("9bb72415-62d6-4fc6-8ea7-b75c4bdd2f16"), 400m, 1, 4 },
                    { new Guid("a6c5fd97-9da3-4b8b-9a22-deebfd9cdcc1"), 300m, 1, 3 },
                    { new Guid("a7a39eb9-2857-49f5-a682-42ac8c2c4292"), 240m, 3, 2 },
                    { new Guid("abb39912-da95-4a90-8c4f-5fb006ead2a1"), 300m, 6, 1 },
                    { new Guid("b374f9cc-c678-4766-93f4-5564d49a1c09"), 300m, 2, 3 },
                    { new Guid("b4693c09-8512-47e6-96d9-e27a476fd351"), 475m, 4, 4 },
                    { new Guid("b799635f-b1e7-44dd-a2d3-447adb86b19d"), 340m, 3, 3 },
                    { new Guid("b89c7fdb-64c4-4e33-91fa-f5c7e6fa5834"), 200m, 2, 2 },
                    { new Guid("bbdeeb89-c879-40e0-81c6-c9c6559ef5e9"), 575m, 4, 5 },
                    { new Guid("bf5bb3cf-beb8-4dc6-848d-88c84d8765af"), 600m, 6, 4 },
                    { new Guid("c09480d3-60ba-45c5-9ed9-263210ef4038"), 540m, 3, 5 },
                    { new Guid("d134793c-f031-42e1-a013-00aec8883df9"), 200m, 1, 2 },
                    { new Guid("d254745f-af67-4a42-8b3a-a676a1990f23"), 100m, 1, 1 },
                    { new Guid("da389746-ff89-40dc-9201-88004508c3c5"), 275m, 4, 2 },
                    { new Guid("e81b7d40-f52a-4f92-b4df-3ef19f39f6d7"), 400m, 6, 2 },
                    { new Guid("f805858a-e5b6-44db-8eed-28214c5cc097"), 100m, 2, 1 },
                    { new Guid("f92c7814-5a71-4f79-86b6-214fa1a45ad3"), 500m, 2, 5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_History_User_UserId",
                table: "History",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_User_CreatedById",
                table: "Hotel",
                column: "CreatedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_User_ModifiedById",
                table: "Hotel",
                column: "ModifiedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_User_CreatedById",
                table: "Occupation",
                column: "CreatedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_User_ModifiedById",
                table: "Occupation",
                column: "ModifiedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_User_CreatedById",
                table: "Picture",
                column: "CreatedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_User_ModifiedById",
                table: "Picture",
                column: "ModifiedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_User_CreatedById",
                table: "Room",
                column: "CreatedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_User_ModifiedById",
                table: "Room",
                column: "ModifiedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomPrice_User_CreatedById",
                table: "RoomPrice",
                column: "CreatedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomPrice_User_ModifiedById",
                table: "RoomPrice",
                column: "ModifiedById",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserPicture_PictureId",
                table: "User",
                column: "PictureId",
                principalTable: "UserPicture",
                principalColumn: "Id");
        }
    }
}
