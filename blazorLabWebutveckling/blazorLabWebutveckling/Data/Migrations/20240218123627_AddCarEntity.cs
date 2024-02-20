using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazorLabWebutveckling.Migrations
{
    /// <inheritdoc />
    public partial class AddCarEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionShort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceEUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DescriptionLong", "DescriptionShort", "ImgUrl", "Name", "PriceEUR", "Qty" },
                values: new object[,]
                {
                    { 1, "", "Mycket blå och cool bil", "Images/blue.png", "Blå bil", 15000m, 10 },
                    { 2, "", "Mycket grön och skön bil", "Images/green.png", "Grön bil", 18000m, 8 },
                    { 3, "", "Snabb gul bil", "Images/yellow.png", "Gul bil", 43000m, 5 },
                    { 4, "", "Jättefin rosa bil", "Images/pink.png", "Rosa bil", 35000m, 4 },
                    { 5, "", "Bästa lila bilen", "Images/lilaFade.png", "Lila bil", 28000m, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
