using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMyPham.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 7, 10, 52, 21, 493, DateTimeKind.Local).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 7, 10, 20, 27, 958, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea"), "c9ce7741-2adb-48ea-837e-0454174af89c", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"), new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"), 0, "1994f6e6-e840-4721-bc16-d33071e9830f", new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "diem99spk@gmail.com", true, "Diem", "Vo", false, null, "diemvo99spk@gmail.com", "admin", "AQAAAAEAACcQAAAAEJY8QnrUsJfulSe3jZqwOCmGa7pbk3PRy2WNk5wzh6TT3cXKNd/e6F7sTTcCqipRWA==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 10, 7, 10, 52, 21, 513, DateTimeKind.Local).AddTicks(4189));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"), new Guid("0471ff08-3e9d-4c2e-9748-9a6252b55eea") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("46064bfd-a12e-4cb6-8d63-6f0ba81aa70d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 7, 10, 20, 27, 958, DateTimeKind.Local).AddTicks(3126),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 7, 10, 52, 21, 493, DateTimeKind.Local).AddTicks(9620));

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
                value: new DateTime(2020, 10, 7, 10, 20, 27, 981, DateTimeKind.Local).AddTicks(6021));
        }
    }
}
