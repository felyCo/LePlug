using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LePlug.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Country", "Name", "PhoneNumber", "PostalCode", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Nairobi", "Kenya", "TrailBlazers", "+254719276623", "0200", "123 Ruaraka" },
                    { 2, "Nairobi", "Kenya", "General Service Unit", "+254726276623", "0200", "124 Drive Inn" },
                    { 3, "Mombasa", "Kenya", "The Dockers", "+254726276623", "0200", "Makupa Docks" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
