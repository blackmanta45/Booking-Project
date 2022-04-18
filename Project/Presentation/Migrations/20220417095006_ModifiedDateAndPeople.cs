using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class ModifiedDateAndPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Hotel_HotelId",
                table: "Occupation");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("0fb0557b-288b-46e9-93bf-f764061baa91"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("11d45449-327c-41d6-aabc-4724ffe69ce9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1ed1b56d-9f82-4e0f-b159-de0a941415f4"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("28adfac9-d2f8-43b5-89f6-8ef45e2071c3"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("2b0405a6-427f-49b9-bcdc-c6bd178d5adb"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("2ef398ad-70c7-4fde-8ca4-0241da1be7ec"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("37a059ed-c28c-43d9-937b-0c68547122ff"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3c9baf9c-dd79-46b7-9e1a-e38249d22bd2"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("489f2763-707e-4759-afc9-371727ce66b1"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("4d6c5f24-66ae-4d6e-b490-5839233cfd0a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("58d3ac39-b5f9-4c95-9270-a9ee5d2b6775"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5b6ea72f-5375-41b2-a63f-3161762b30d2"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("70398a35-fbf1-4f94-9f2a-17308cd473e5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("76c77b30-aa57-4d24-aa39-ab13a39e0818"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("77b41216-f546-4909-800e-39b9a9869111"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("880c977b-6585-401b-a6b4-33a6ad38ce13"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("9deebda0-e42b-49eb-87db-8facb19fc275"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("bca1ff67-e06b-48f2-9584-642e4e5c02cc"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c06e0871-eb42-428f-b978-26af7db6f20b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c225886a-ed1f-4554-ad0c-5cfbcefa5cb8"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c8e77c4f-b125-4b55-a800-fd653bd42475"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("daa9cd9c-394c-4458-9295-116392c0e389"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("eb045838-d70d-4766-9303-48376876fa07"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("f5a377e5-6365-4947-b9f8-1511b1ae24fc"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("fe341f39-173f-4f98-8786-7f7756b7e214"));

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "Occupation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Occupation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "DefaultPrice", "People", "Stars" },
                values: new object[,]
                {
                    { new Guid("051661e7-2331-4c4d-9ec5-16e637129d84"), 700m, 6, 5 },
                    { new Guid("0a24ac20-97d7-4683-b620-e0a267547354"), 400m, 1, 4 },
                    { new Guid("0fdc69fd-1ff7-4978-aecb-872a87d147e9"), 300m, 2, 3 },
                    { new Guid("19ad9571-7fd7-4ecb-bb87-71326f7e41c9"), 500m, 6, 3 },
                    { new Guid("19c757e5-4f6d-42cd-9fb1-93cc523f1582"), 200m, 1, 2 },
                    { new Guid("1cdb2de8-e319-45bf-8aa8-5924593a8ec7"), 375m, 4, 3 },
                    { new Guid("35bde987-7e1c-4922-8b7e-143efff5e06f"), 650m, 5, 5 },
                    { new Guid("3d6b724d-7d1a-423f-b697-40768a73c787"), 250m, 5, 1 },
                    { new Guid("46725e13-19d9-4ead-afbf-1fcf174e7c0a"), 400m, 6, 2 },
                    { new Guid("5f9ef509-6bd7-466d-a34d-075ede43c2a7"), 300m, 6, 1 },
                    { new Guid("7d276888-9b39-47d8-b85c-f14ec495add0"), 300m, 1, 3 },
                    { new Guid("7f477dc1-7c4a-472a-97c3-b49698c3bc2f"), 275m, 4, 2 },
                    { new Guid("82eb55a2-e2f3-43e4-bb4a-636269859950"), 200m, 2, 2 },
                    { new Guid("88b69a51-b14c-44fe-a3b3-f3c5c96fba3a"), 100m, 1, 1 },
                    { new Guid("92842ba9-df4b-494b-9e15-17feed94fbd2"), 240m, 3, 2 },
                    { new Guid("9db08bed-2cba-47c4-a22d-87925b2557a0"), 340m, 3, 3 },
                    { new Guid("9e17bee7-4d54-4d7d-ba48-cecd8e703e4d"), 600m, 6, 4 },
                    { new Guid("a962936f-618a-4bfa-8b76-7c9716a45b25"), 500m, 1, 5 },
                    { new Guid("afececc5-ff31-4232-9066-0cb40a65ae48"), 550m, 5, 4 },
                    { new Guid("b76b3137-a4a5-418f-a070-e9cd3e03dfa6"), 100m, 2, 1 },
                    { new Guid("bf8ac7da-01c6-4659-a493-93125fb6fc0c"), 475m, 4, 4 },
                    { new Guid("c5272c47-4596-4910-b2a6-bbaebd6be301"), 175m, 4, 1 },
                    { new Guid("c7c26dca-484e-496b-a20b-df574b5697a4"), 140m, 3, 1 },
                    { new Guid("da471d9f-f4cf-46fa-a006-e4e3103f0dff"), 500m, 2, 5 },
                    { new Guid("e20d7165-f87e-4f1e-b11d-93e3859c755e"), 450m, 5, 3 },
                    { new Guid("e381360e-3310-4bc2-b03d-60774a75b164"), 350m, 5, 2 },
                    { new Guid("e52ff985-b4bb-4e35-8e17-b56809571910"), 400m, 2, 4 },
                    { new Guid("e60aa4b2-a97a-4c01-b62e-aa181c27fbcf"), 575m, 4, 5 },
                    { new Guid("e963fe7e-6df7-488d-9a8e-42925dd21c12"), 540m, 3, 5 },
                    { new Guid("f9bad79e-2553-49f8-9443-64d07b74e13c"), 440m, 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Occupation_RoomId",
                table: "Occupation",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Hotel_HotelId",
                table: "Occupation",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Room_RoomId",
                table: "Occupation",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Hotel_HotelId",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Room_RoomId",
                table: "Occupation");

            migrationBuilder.DropIndex(
                name: "IX_Occupation_RoomId",
                table: "Occupation");

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("051661e7-2331-4c4d-9ec5-16e637129d84"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("0a24ac20-97d7-4683-b620-e0a267547354"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("0fdc69fd-1ff7-4978-aecb-872a87d147e9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("19ad9571-7fd7-4ecb-bb87-71326f7e41c9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("19c757e5-4f6d-42cd-9fb1-93cc523f1582"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1cdb2de8-e319-45bf-8aa8-5924593a8ec7"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("35bde987-7e1c-4922-8b7e-143efff5e06f"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3d6b724d-7d1a-423f-b697-40768a73c787"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("46725e13-19d9-4ead-afbf-1fcf174e7c0a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5f9ef509-6bd7-466d-a34d-075ede43c2a7"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7d276888-9b39-47d8-b85c-f14ec495add0"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7f477dc1-7c4a-472a-97c3-b49698c3bc2f"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("82eb55a2-e2f3-43e4-bb4a-636269859950"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("88b69a51-b14c-44fe-a3b3-f3c5c96fba3a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("92842ba9-df4b-494b-9e15-17feed94fbd2"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("9db08bed-2cba-47c4-a22d-87925b2557a0"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("9e17bee7-4d54-4d7d-ba48-cecd8e703e4d"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("a962936f-618a-4bfa-8b76-7c9716a45b25"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("afececc5-ff31-4232-9066-0cb40a65ae48"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b76b3137-a4a5-418f-a070-e9cd3e03dfa6"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("bf8ac7da-01c6-4659-a493-93125fb6fc0c"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c5272c47-4596-4910-b2a6-bbaebd6be301"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c7c26dca-484e-496b-a20b-df574b5697a4"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("da471d9f-f4cf-46fa-a006-e4e3103f0dff"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e20d7165-f87e-4f1e-b11d-93e3859c755e"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e381360e-3310-4bc2-b03d-60774a75b164"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e52ff985-b4bb-4e35-8e17-b56809571910"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e60aa4b2-a97a-4c01-b62e-aa181c27fbcf"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e963fe7e-6df7-488d-9a8e-42925dd21c12"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("f9bad79e-2553-49f8-9443-64d07b74e13c"));

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Occupation");

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "Occupation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "DefaultPrice", "People", "Stars" },
                values: new object[,]
                {
                    { new Guid("0fb0557b-288b-46e9-93bf-f764061baa91"), 500m, 6, 3 },
                    { new Guid("11d45449-327c-41d6-aabc-4724ffe69ce9"), 200m, 2, 2 },
                    { new Guid("1ed1b56d-9f82-4e0f-b159-de0a941415f4"), 700m, 6, 5 },
                    { new Guid("28adfac9-d2f8-43b5-89f6-8ef45e2071c3"), 375m, 4, 3 },
                    { new Guid("2b0405a6-427f-49b9-bcdc-c6bd178d5adb"), 400m, 2, 4 },
                    { new Guid("2ef398ad-70c7-4fde-8ca4-0241da1be7ec"), 250m, 5, 1 },
                    { new Guid("37a059ed-c28c-43d9-937b-0c68547122ff"), 140m, 3, 1 },
                    { new Guid("3c9baf9c-dd79-46b7-9e1a-e38249d22bd2"), 400m, 6, 2 },
                    { new Guid("489f2763-707e-4759-afc9-371727ce66b1"), 340m, 3, 3 },
                    { new Guid("4d6c5f24-66ae-4d6e-b490-5839233cfd0a"), 475m, 4, 4 },
                    { new Guid("58d3ac39-b5f9-4c95-9270-a9ee5d2b6775"), 275m, 4, 2 },
                    { new Guid("5b6ea72f-5375-41b2-a63f-3161762b30d2"), 540m, 3, 5 },
                    { new Guid("70398a35-fbf1-4f94-9f2a-17308cd473e5"), 300m, 2, 3 },
                    { new Guid("76c77b30-aa57-4d24-aa39-ab13a39e0818"), 450m, 5, 3 },
                    { new Guid("77b41216-f546-4909-800e-39b9a9869111"), 300m, 6, 1 },
                    { new Guid("880c977b-6585-401b-a6b4-33a6ad38ce13"), 175m, 4, 1 },
                    { new Guid("9deebda0-e42b-49eb-87db-8facb19fc275"), 100m, 2, 1 },
                    { new Guid("bca1ff67-e06b-48f2-9584-642e4e5c02cc"), 650m, 5, 5 },
                    { new Guid("c06e0871-eb42-428f-b978-26af7db6f20b"), 600m, 6, 4 },
                    { new Guid("c225886a-ed1f-4554-ad0c-5cfbcefa5cb8"), 240m, 3, 2 },
                    { new Guid("c8e77c4f-b125-4b55-a800-fd653bd42475"), 550m, 5, 4 },
                    { new Guid("daa9cd9c-394c-4458-9295-116392c0e389"), 575m, 4, 5 },
                    { new Guid("eb045838-d70d-4766-9303-48376876fa07"), 440m, 3, 4 },
                    { new Guid("f5a377e5-6365-4947-b9f8-1511b1ae24fc"), 500m, 2, 5 },
                    { new Guid("fe341f39-173f-4f98-8786-7f7756b7e214"), 350m, 5, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Hotel_HotelId",
                table: "Occupation",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
