using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Korzina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korzina",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tovarid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    ShopTovarId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korzina", x => x.id);
                    table.ForeignKey(
                        name: "FK_Korzina_Tovar_Tovarid",
                        column: x => x.Tovarid,
                        principalTable: "Tovar",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korzina_Tovarid",
                table: "Korzina",
                column: "Tovarid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korzina");
        }
    }
}
