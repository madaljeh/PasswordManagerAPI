using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImplementAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsernameTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: true),
                    UserNameNonce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNameTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordNonce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 6, 6, 21, 31, 0, 518, DateTimeKind.Local).AddTicks(447));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 20, 13, 19, 598, DateTimeKind.Local).AddTicks(2545));
        }
    }
}
