using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoTransportationServer.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Fuel_FuelId",
                table: "Autos");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("576da2ac-f86d-403c-98b2-c8a05e6b674e"));

            migrationBuilder.DropColumn(
                name: "IdFuel",
                table: "Autos");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelId",
                table: "Autos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "PersonId" },
                values: new object[] { new Guid("c1416282-ebad-4aea-b84d-d41c340a34a0"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Fuel_FuelId",
                table: "Autos",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Fuel_FuelId",
                table: "Autos");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c1416282-ebad-4aea-b84d-d41c340a34a0"));

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelId",
                table: "Autos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Fuel_FuelId",
                table: "Autos",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id");
        }
    }
}
