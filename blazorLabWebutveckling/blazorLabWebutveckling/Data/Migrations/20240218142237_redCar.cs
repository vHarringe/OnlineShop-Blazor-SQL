using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazorLabWebutveckling.Migrations
{
    /// <inheritdoc />
    public partial class redCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionShort", "ImgUrl", "Name" },
                values: new object[] { "Bästa röda bilen", "Images/red.png", "Röd bil" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionShort", "ImgUrl", "Name" },
                values: new object[] { "Bästa lila bilen", "Images/lilaFade.png", "Lila bil" });
        }
    }
}
