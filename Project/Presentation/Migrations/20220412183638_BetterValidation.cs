using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class BetterValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("04a7e419-4885-4f92-bd8b-545de1d3b919"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("1acc14b1-8394-4aa5-9a11-da9cdd3d5693"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5a63bbd2-1727-494d-97f5-1309a23216c9"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5c538d6f-5ec8-4a9a-890f-b11412742e9b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("5db19b3d-e811-400a-8329-97f9ca930f81"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("653b5183-909c-480b-9a53-2fb1e98213ee"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("6555a543-65a0-4467-8f3a-85f0a6208598"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("6b686902-353a-4a1f-9b90-d3cbe184d7d6"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("6ce2aeec-2ccf-47f8-a93f-4930a31c4fd5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("8454ad09-843f-4f00-9368-7dd2e6cb4b5b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("8dbb54c8-537d-41a8-b37d-6a3d40a48d40"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("999bdaed-1ac3-4af2-9276-14bdb1b37d73"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("99f29838-2767-4df0-b965-699256f6c484"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b10fd4de-39fd-4489-94a0-e3a203113709"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b1185d95-5f0a-4226-b324-2c2344b102fd"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("b8870fcd-226b-46d9-bad0-c4210798ef7d"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("bdc17b0a-1404-4d5f-a77d-f5f5a8151e88"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c4a94aa1-1f30-4b0f-a573-24e9b9f3e1c5"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("c8936a4f-d325-41a3-87d1-a5a1206aba5b"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("cae1e4d3-e0f7-4d92-bfc6-ee1435d7bd04"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e8d1d974-acaf-4818-ade2-5d7ecb926b54"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("e93d7d44-bc61-479f-b85e-5d2e389d3802"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("fbae9047-1045-4c2e-a1ae-6468dc2bebd2"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("fc34bde8-017b-46cc-8bbb-5ad69e7643a8"));

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: new Guid("ff7d3b5a-cb4d-4075-8e2d-53081ebdf27e"));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "DefaultPrice", "People", "Stars" },
                values: new object[,]
                {
                    { new Guid("04a7e419-4885-4f92-bd8b-545de1d3b919"), 500m, 2, 5 },
                    { new Guid("1acc14b1-8394-4aa5-9a11-da9cdd3d5693"), 575m, 4, 5 },
                    { new Guid("5a63bbd2-1727-494d-97f5-1309a23216c9"), 140m, 3, 1 },
                    { new Guid("5c538d6f-5ec8-4a9a-890f-b11412742e9b"), 300m, 2, 3 },
                    { new Guid("5db19b3d-e811-400a-8329-97f9ca930f81"), 400m, 2, 4 },
                    { new Guid("653b5183-909c-480b-9a53-2fb1e98213ee"), 475m, 4, 4 },
                    { new Guid("6555a543-65a0-4467-8f3a-85f0a6208598"), 400m, 6, 3 },
                    { new Guid("6b686902-353a-4a1f-9b90-d3cbe184d7d6"), 450m, 5, 3 },
                    { new Guid("6ce2aeec-2ccf-47f8-a93f-4930a31c4fd5"), 175m, 4, 1 },
                    { new Guid("8454ad09-843f-4f00-9368-7dd2e6cb4b5b"), 100m, 2, 1 },
                    { new Guid("8dbb54c8-537d-41a8-b37d-6a3d40a48d40"), 440m, 3, 4 },
                    { new Guid("999bdaed-1ac3-4af2-9276-14bdb1b37d73"), 200m, 2, 2 },
                    { new Guid("99f29838-2767-4df0-b965-699256f6c484"), 250m, 5, 1 },
                    { new Guid("b10fd4de-39fd-4489-94a0-e3a203113709"), 540m, 3, 5 },
                    { new Guid("b1185d95-5f0a-4226-b324-2c2344b102fd"), 550m, 5, 4 },
                    { new Guid("b8870fcd-226b-46d9-bad0-c4210798ef7d"), 240m, 3, 2 },
                    { new Guid("bdc17b0a-1404-4d5f-a77d-f5f5a8151e88"), 600m, 6, 4 },
                    { new Guid("c4a94aa1-1f30-4b0f-a573-24e9b9f3e1c5"), 350m, 5, 2 },
                    { new Guid("c8936a4f-d325-41a3-87d1-a5a1206aba5b"), 300m, 6, 1 },
                    { new Guid("cae1e4d3-e0f7-4d92-bfc6-ee1435d7bd04"), 400m, 6, 2 },
                    { new Guid("e8d1d974-acaf-4818-ade2-5d7ecb926b54"), 700m, 6, 5 },
                    { new Guid("e93d7d44-bc61-479f-b85e-5d2e389d3802"), 340m, 3, 3 },
                    { new Guid("fbae9047-1045-4c2e-a1ae-6468dc2bebd2"), 275m, 4, 2 },
                    { new Guid("fc34bde8-017b-46cc-8bbb-5ad69e7643a8"), 375m, 4, 3 },
                    { new Guid("ff7d3b5a-cb4d-4075-8e2d-53081ebdf27e"), 650m, 5, 5 }
                });
        }
    }
}
