using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class AddedShortDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "DefaultPrice", "People", "Stars" },
                values: new object[,]
                {
                    { new Guid("08b9f148-6599-4848-8486-6b28cde90389"), 600m, 6, 4 },
                    { new Guid("157cd66b-4b67-4baf-9dc0-4a62ae3a039e"), 140m, 3, 1 },
                    { new Guid("1e03f289-2795-4ca4-8a89-9a457eb4ce52"), 250m, 5, 1 },
                    { new Guid("1e410d19-8732-4a83-ac71-7127b8c00ea8"), 200m, 1, 2 },
                    { new Guid("1ee45d85-2d5f-47ab-aa92-50f091c1ea74"), 450m, 5, 3 },
                    { new Guid("2b7578db-8d6e-4be4-8b47-6475e3cbbd1b"), 400m, 6, 2 },
                    { new Guid("2e5c85d9-753e-4d48-a6e2-c2b17ad97870"), 400m, 2, 4 },
                    { new Guid("3345ceee-4d0e-445e-ab4d-d9de860edb9a"), 500m, 2, 5 },
                    { new Guid("3385489d-c0f2-4b21-8b21-2baaa8ada757"), 200m, 2, 2 },
                    { new Guid("36869323-fc5e-46bf-b87b-105d9d1225c7"), 300m, 1, 3 },
                    { new Guid("37c0ce04-0184-48ea-b1f4-b5a92bc4353a"), 300m, 2, 3 },
                    { new Guid("3e2e1927-0c0d-4bb3-9f57-ed502c4e288b"), 175m, 4, 1 },
                    { new Guid("3f38c435-c5e5-41e2-952f-4fb6884c6694"), 340m, 3, 3 },
                    { new Guid("4b0cbd97-7ea8-4970-8881-aad34c292fff"), 540m, 3, 5 },
                    { new Guid("7229b300-3b67-4471-8946-d9e6a05002c6"), 100m, 1, 1 },
                    { new Guid("73caeb6a-6e67-4ab9-a36b-9827567168f5"), 375m, 4, 3 },
                    { new Guid("7fa8eedc-351f-4a26-b1df-1c4737e2277a"), 100m, 2, 1 },
                    { new Guid("7ff63d1f-dcc7-4b92-af2b-f4a44ddedabf"), 550m, 5, 4 },
                    { new Guid("8f4b2ec0-3249-46f6-8950-e1c4ea91b0c0"), 500m, 6, 3 },
                    { new Guid("8f9ca21d-aba9-4034-a479-2c850764eef1"), 275m, 4, 2 },
                    { new Guid("96b4066f-c758-4655-97ef-2bb0f81a780a"), 500m, 1, 5 },
                    { new Guid("a382e0b0-1e17-47c4-921b-39968384824d"), 350m, 5, 2 },
                    { new Guid("a595ff56-72d6-40cd-b24b-febc963c6040"), 400m, 1, 4 },
                    { new Guid("b1a34bbf-b1dd-4e50-ac9d-6d9ecaab6113"), 300m, 6, 1 },
                    { new Guid("b6655299-1d7c-42ca-87ca-730579fda317"), 650m, 5, 5 },
                    { new Guid("c374f512-ea45-4547-aa8f-c2a7ec975c29"), 575m, 4, 5 },
                    { new Guid("c82a5eb3-e634-4b74-94f1-08126890da96"), 440m, 3, 4 },
                    { new Guid("e076bdc1-df60-4c95-8cb3-0416975da5d0"), 240m, 3, 2 },
                    { new Guid("e11cee64-0e8c-42ac-a661-319021efef4c"), 700m, 6, 5 },
                    { new Guid("e1383a2a-0437-4899-9ff7-3186822efd84"), 475m, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("08b9f148-6599-4848-8486-6b28cde90389"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("157cd66b-4b67-4baf-9dc0-4a62ae3a039e"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1e03f289-2795-4ca4-8a89-9a457eb4ce52"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1e410d19-8732-4a83-ac71-7127b8c00ea8"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1ee45d85-2d5f-47ab-aa92-50f091c1ea74"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("2b7578db-8d6e-4be4-8b47-6475e3cbbd1b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("2e5c85d9-753e-4d48-a6e2-c2b17ad97870"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3345ceee-4d0e-445e-ab4d-d9de860edb9a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3385489d-c0f2-4b21-8b21-2baaa8ada757"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("36869323-fc5e-46bf-b87b-105d9d1225c7"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("37c0ce04-0184-48ea-b1f4-b5a92bc4353a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3e2e1927-0c0d-4bb3-9f57-ed502c4e288b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("3f38c435-c5e5-41e2-952f-4fb6884c6694"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("4b0cbd97-7ea8-4970-8881-aad34c292fff"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7229b300-3b67-4471-8946-d9e6a05002c6"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("73caeb6a-6e67-4ab9-a36b-9827567168f5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7fa8eedc-351f-4a26-b1df-1c4737e2277a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("7ff63d1f-dcc7-4b92-af2b-f4a44ddedabf"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("8f4b2ec0-3249-46f6-8950-e1c4ea91b0c0"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("8f9ca21d-aba9-4034-a479-2c850764eef1"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("96b4066f-c758-4655-97ef-2bb0f81a780a"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("a382e0b0-1e17-47c4-921b-39968384824d"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("a595ff56-72d6-40cd-b24b-febc963c6040"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b1a34bbf-b1dd-4e50-ac9d-6d9ecaab6113"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b6655299-1d7c-42ca-87ca-730579fda317"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c374f512-ea45-4547-aa8f-c2a7ec975c29"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c82a5eb3-e634-4b74-94f1-08126890da96"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e076bdc1-df60-4c95-8cb3-0416975da5d0"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e11cee64-0e8c-42ac-a661-319021efef4c"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e1383a2a-0437-4899-9ff7-3186822efd84"));

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Hotel");

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
        }
    }
}
