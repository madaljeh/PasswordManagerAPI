using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImplementProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 17, 41, 28, 587, DateTimeKind.Local).AddTicks(8728));
        }
    }
}
