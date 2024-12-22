using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTransportationServer.Migrations
{
    /// <inheritdoc />
    public partial class C : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7654c064-4f85-45e0-823a-df629429aa81"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuelId",
                table: "Autos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "IdFuel",
                table: "Autos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("576da2ac-f86d-403c-98b2-c8a05e6b674e"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.CreateIndex(
                name: "IX_Autos_FuelId",
                table: "Autos",
                column: "FuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Fuel_FuelId",
                table: "Autos",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Fuel_FuelId",
                table: "Autos");

            migrationBuilder.DropIndex(
                name: "IX_Autos_FuelId",
                table: "Autos");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("576da2ac-f86d-403c-98b2-c8a05e6b674e"));

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "IdFuel",
                table: "Autos");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("7654c064-4f85-45e0-823a-df629429aa81"), new Guid("00000000-0000-0000-0000-000000000001") });
        }
    }
}
