using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMyPham.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea"),
                column: "ConcurrencyStamp",
                value: "27783fa3-ef25-4f9a-94f4-5ebfb9ba245c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef93ed5a-d420-4741-97b1-455dcc051b70", "AQAAAAEAACcQAAAAEIKpxkGF4lEMA7N62ej9ABJPNGOQnjSILZSk+CThL6qtKTMPQ7ebrwqMUkA3XttTzA==" });

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
                value: new DateTime(2020, 10, 29, 18, 12, 51, 423, DateTimeKind.Local).AddTicks(206));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea"),
                column: "ConcurrencyStamp",
                value: "9a89153d-3c36-4f6e-9cb5-fdac5bfdc7ba");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed0b2348-7e94-49f9-b0f3-2e3c507d758b", "AQAAAAEAACcQAAAAEKqAFteAPprPWCxhQKwN7MpE38I5damPCE4CbG5W6m3KO2Lkp+T3gjwDwDY+OWN4WQ==" });

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
                value: new DateTime(2020, 10, 29, 18, 7, 20, 362, DateTimeKind.Local).AddTicks(1995));
        }
    }
}
