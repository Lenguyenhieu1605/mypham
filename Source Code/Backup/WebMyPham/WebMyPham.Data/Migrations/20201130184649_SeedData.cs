using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMyPham.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "ConcurrencyStamp",
                value: "d3bc4211-e90f-4f94-8ab9-dd15ab29ed74");

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "ConcurrencyStamp",
                value: "f02482f8-6a2f-45ef-9712-395d2a188bcb");

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "ConcurrencyStamp",
                value: "bb4a1f16-f6d9-43ba-b4d2-ff562fb539df");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea"),
                column: "ConcurrencyStamp",
                value: "93a38bb4-77ce-4f1f-880e-cd6bca52ea18");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10641cf6-9446-4d02-941c-2f49ae19bedc", "AQAAAAEAACcQAAAAEIXN0YfxOrtccKsbRVfLrU57zR9fbXsfaTIK9LpyVCdc/F76+ayKfnZzvCsFIDDugw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 1, 1, 46, 48, 331, DateTimeKind.Local).AddTicks(7787));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "ConcurrencyStamp",
                value: "ca472bc5-64c7-476e-b285-54c59b777686");

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "ConcurrencyStamp",
                value: "9f5f381c-5a00-4d30-a982-a20570e6ac31");

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "ConcurrencyStamp",
                value: "4a1ae08a-f60f-46a2-accf-da0a3a0afa0b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea"),
                column: "ConcurrencyStamp",
                value: "78618913-2916-4ee9-8959-d93d721050ff");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d41e8ae-fb80-495d-841b-5a699dd5dc53", "AQAAAAEAACcQAAAAEAiSBogUVomdzYJ0Q8WvBT44IbWd9YMfjFBzptJJpDb9/Fm51yRW5dV1bG4ZqUFmjg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 1, 1, 32, 29, 396, DateTimeKind.Local).AddTicks(5846));
        }
    }
}
