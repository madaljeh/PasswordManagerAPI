using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PasswordManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OTPCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "LookupItems",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "IsActive", "LookupTypeID", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8691), true, 2, "Client", null, null },
                    { 2, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8692), true, 2, "Admin", null, null },
                    { 10, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8688), true, 1, "Jordanian", null, null },
                    { 100, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8693), true, 3, "Phone", null, null },
                    { 101, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8695), true, 3, "Name", null, null },
                    { 102, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8696), true, 3, "Email", null, null },
                    { 103, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8697), true, 3, "UserName", null, null },
                    { 104, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8698), true, 3, "National ID", null, null },
                    { 200, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8699), true, 4, "Trainer", null, null },
                    { 201, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8700), true, 4, "Manger", null, null },
                    { 300, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8700), true, 5, "Personal", null, null },
                    { 301, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8701), true, 5, "Banking", null, null },
                    { 302, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8702), true, 5, "Social Media", null, null },
                    { 303, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8703), true, 5, "Other", null, null }
                });

            migrationBuilder.InsertData(
                table: "LookupTypes",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "IsActive", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8538), true, "Nationality", null, null },
                    { 2, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8549), true, "Role", null, null },
                    { 3, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8550), true, "UserNameType", null, null },
                    { 4, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8551), true, "Specialization", null, null },
                    { 5, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8552), true, "Category", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "Email", "IsActive", "IsLoggedIn", "IsVerfied", "LastLoginTime", "OTPCode", "OTPExipry", "Password", "RoleId", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[] { 1, "System", new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8728), "ecef5da14d3354e2a9b2b270109f1e33c3d8fc6e19eab5cd35bab4816804314d07f0cffe5140a77d66cb8f7375201941", true, false, true, null, null, null, "2f462fe1506e0550eaba3dab121eadfd47f0d12128c0af326fdc0ad23673fcc730d4c6c1dc0710765dbadd18cba262b4", 2, null, null, "e276366b3cb0f0385b1bc245978527bc4833779904ea0b159ea08a22b2d125e3c2b72514001d58878610b63e985f7650" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "OTPCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
