using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImplementProvider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 19, 17, 44, 491, DateTimeKind.Local).AddTicks(6049));
        }
    }
}
