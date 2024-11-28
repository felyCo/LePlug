using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LePlug.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.jumia.co.ke%2Fmikasa-official-match-ball-for-volleyball-size-4-mva330-218656549.html&psig=AOvVaw2FvZh5_7AiwHZu9TkzjqQE&ust=1724322979806000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCLj05fHxhYgDFQAAAAAdAAAAABAI");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://s.turbifycdn.com/aah/q-sport/volleyball-rising-hooded-sweatshirt-in-20-colors-54.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.indiamart.com%2Fproddetail%2Fasics-sky-elite-ff-mt-2-tokyo-volleyball-shoes-24668676662.html&psig=AOvVaw0dekzg2sWyQmvS8saFN_rM&ust=1724323289252000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCIDu0IHzhYgDFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.walmart.com%2Fip%2FMizuno-Volleyball-Elite-Kneepads-White%2F192436285&psig=AOvVaw0HWRoHS3u0rQ6irT8lg5A0&ust=1724323365841000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCIi8_sHzhYgDFQAAAAAdAAAAABAE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
