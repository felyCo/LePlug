using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LePlug.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addOrderHeaderUpdateAndDetailsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreerAddress",
                table: "OrderHeaders",
                newName: "StreetAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "OrderHeaders",
                newName: "StreerAddress");
        }
    }
}
