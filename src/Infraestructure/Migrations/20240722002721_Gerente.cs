using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Gerente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Activo", "Contraseña", "Email", "Nombre", "UserType" },
                values: new object[,]
                {
                    { 5, false, "123456", "cbologna31@gmail.com", "carlos", "Vendedor" },
                    { 6, false, "123456", "gfurrer@gmail.com", "Gabriel", "Vendedor" },
                    { 7, false, "1234", "Caetano1@gmail.com", "Caetano", "Gerente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Activo", "Contraseña", "Email", "Nombre", "UserType" },
                values: new object[,]
                {
                    { 9, false, "123456", "cbologna31@gmail.com", "carlos", "Vendedor" },
                    { 10, false, "123456", "gfurrer@gmail.com", "Gabriel", "Vendedor" }
                });
        }
    }
}
