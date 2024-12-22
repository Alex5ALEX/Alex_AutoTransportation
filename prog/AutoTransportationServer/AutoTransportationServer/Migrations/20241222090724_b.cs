using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTransportationServer.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("24c53556-dd25-4993-bcc5-58f1c6662fb9"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("7654c064-4f85-45e0-823a-df629429aa81"), new Guid("00000000-0000-0000-0000-000000000001") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7654c064-4f85-45e0-823a-df629429aa81"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("24c53556-dd25-4993-bcc5-58f1c6662fb9"), new Guid("00000000-0000-0000-0000-000000000001") });
        }
    }
}
