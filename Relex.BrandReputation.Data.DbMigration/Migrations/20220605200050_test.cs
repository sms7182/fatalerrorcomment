using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relex.BrandReputation.Data.DbMigration.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("18e87ce1-dff4-4746-b84c-93c4ce671086"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7144), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 4, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("1f9ee90a-b5f3-4df5-87a2-c82e8f1f6b12"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 27, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 5, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("301204e2-ff74-4452-81a9-07149daf682b"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 23, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7058), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 2, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("3beaf95c-8256-492b-b42c-1f816b89d315"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7103), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7112), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 27, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("584db01e-236e-4b9d-862f-f0f7ca3ee334"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 4, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("66a9116a-cc5e-4f4b-b6f2-df1fd71ccf4f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 26, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 17, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 1, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("7766d469-a916-4d46-8727-d77301bbda7f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("971bee8e-2854-403b-8a96-7b1605f63062"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 17, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6842), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("a07765bf-5631-4524-9d76-9a7e3c463057"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 22, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 5, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("af1ee3be-8530-40d1-85d2-dd7522ba3e35"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 27, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bb030157-cb80-4b53-9c42-8a8ead8526d1"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6889), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 30, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bf34b132-dea4-4a68-aabf-4290f0d4b150"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 23, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 1, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("c51d59c2-6647-4578-9704-0730dc71cecf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 24, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 1, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7001), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("cd9ab33c-a45a-4085-a6df-a5e5f3a6c5c0"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6954), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 23, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6961), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("e8ae7f4c-62c5-4b41-b4e7-22e57e4f57fd"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 19, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 3, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("f7ad5597-2da9-4285-8812-3372b7acf820"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 2, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7086), new TimeSpan(0, 4, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("fa1ffed7-10d8-4996-ad25-91b47f937178"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 17, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7195), new TimeSpan(0, 4, 30, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 4, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7191), new TimeSpan(0, 4, 30, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("18e87ce1-dff4-4746-b84c-93c4ce671086"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8035), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 22, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 26, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("1f9ee90a-b5f3-4df5-87a2-c82e8f1f6b12"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7750), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 27, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("301204e2-ff74-4452-81a9-07149daf682b"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7942), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 18, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7947), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 2, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7944), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("3beaf95c-8256-492b-b42c-1f816b89d315"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 22, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7982), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 21, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7997), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("584db01e-236e-4b9d-862f-f0f7ca3ee334"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 19, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7719), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 23, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7725), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 27, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7722), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("66a9116a-cc5e-4f4b-b6f2-df1fd71ccf4f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 22, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 23, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 3, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7668), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("7766d469-a916-4d46-8727-d77301bbda7f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8065), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 27, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8062), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("971bee8e-2854-403b-8a96-7b1605f63062"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 19, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 18, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 1, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7639), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("a07765bf-5631-4524-9d76-9a7e3c463057"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 22, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7793), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 28, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7790), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("af1ee3be-8530-40d1-85d2-dd7522ba3e35"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 16, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7932), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 3, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7916), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bb030157-cb80-4b53-9c42-8a8ead8526d1"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 21, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 15, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 26, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bf34b132-dea4-4a68-aabf-4290f0d4b150"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7828), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 23, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7846), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 26, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("c51d59c2-6647-4578-9704-0730dc71cecf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 25, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7814), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 18, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 26, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("cd9ab33c-a45a-4085-a6df-a5e5f3a6c5c0"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 22, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 30, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("e8ae7f4c-62c5-4b41-b4e7-22e57e4f57fd"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 21, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 22, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 28, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("f7ad5597-2da9-4285-8812-3372b7acf820"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 23, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 23, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 1, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(7972), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Domain",
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("fa1ffed7-10d8-4996-ad25-91b47f937178"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 5, 18, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 6, 20, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8091), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 14, 49, 35, 311, DateTimeKind.Unspecified).AddTicks(8088), new TimeSpan(0, 8, 0, 0, 0)) });
        }
    }
}
