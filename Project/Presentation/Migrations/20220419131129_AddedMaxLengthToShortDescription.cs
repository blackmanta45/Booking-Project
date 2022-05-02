using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class AddedMaxLengthToShortDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Hotel",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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
    }
}
