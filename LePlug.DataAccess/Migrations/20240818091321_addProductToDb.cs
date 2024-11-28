using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LePlug.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ListPrice", "Manufacturer", "Price", "Price100", "Price50", "ProductName" },
                values: new object[,]
                {
                    { 1, "Designed with a unique 8-panel swirl design, this ball offers superior visibility when in flight. This in turn improves accuracy during bumps, sets, and spikes. Composite leather cover provides low sting on wrists and arms and stands up to rough, routine play indoors. Nylon-wound center and composite bladder retain air and ball shape. Official size.", 5999.0, "Mikasa Inc", 5799.0, 4999.0, 5299.0, "Mikasa MVA330 Composite Volleyball" },
                    { 2, "The hoodie is made of thick cotton fabric which keeps in body heat so you can stay warm and comfortable.This drawstring double fabric hoodie with self-coloured", 2500.0, "Urban Volleyball", 2299.0, 1999.0, 2199.0, "High Quality Hoodie" },
                    { 3, "Explore our wide selection of men's volleyball shoes and sneakers! We carry the top-of-the-line brands like Nike, Mizuno, Adidas, and so much more", 2500.0, "Asics", 2299.0, 1999.0, 2199.0, "Sport Shoes" },
                    { 4, "Keep your eyes on the net, not the floor. These adidas volleyball kneepads are made to fit the contours of your knee for a comfortable wear.", 2500.0, "Addidas", 2299.0, 1999.0, 2199.0, "Knee Pads" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
