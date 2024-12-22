using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTransportationServer.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("541c91a0-de54-45e8-a1f0-12c7ceb4796a"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("24c53556-dd25-4993-bcc5-58f1c6662fb9"), new Guid("00000000-0000-0000-0000-000000000001") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("24c53556-dd25-4993-bcc5-58f1c6662fb9"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("541c91a0-de54-45e8-a1f0-12c7ceb4796a"), new Guid("00000000-0000-0000-0000-000000000001") });
        }
    }
}
