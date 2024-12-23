using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTransportationServer.Migrations
{
    /// <inheritdoc />
    public partial class e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c1416282-ebad-4aea-b84d-d41c340a34a0"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Transportations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("c74c153e-aa0f-450d-aaba-789110a9a40a"), new Guid("00000000-0000-0000-0000-000000000001") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c74c153e-aa0f-450d-aaba-789110a9a40a"));

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Transportations");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("c1416282-ebad-4aea-b84d-d41c340a34a0"), new Guid("00000000-0000-0000-0000-000000000001") });
        }
    }
}
