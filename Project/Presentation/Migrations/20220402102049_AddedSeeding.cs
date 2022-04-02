using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    public partial class AddedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
