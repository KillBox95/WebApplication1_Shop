using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Zakazy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zakazs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zakazTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zakazs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ZakazDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zakazId = table.Column<int>(type: "int", nullable: false),
                    tovarId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZakazDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ZakazDetail_Tovar_tovarId",
                        column: x => x.tovarId,
                        principalTable: "Tovar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZakazDetail_Zakazs_zakazId",
                        column: x => x.zakazId,
                        principalTable: "Zakazs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZakazDetail_tovarId",
                table: "ZakazDetail",
                column: "tovarId");

            migrationBuilder.CreateIndex(
                name: "IX_ZakazDetail_zakazId",
                table: "ZakazDetail",
                column: "zakazId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZakazDetail");

            migrationBuilder.DropTable(
                name: "Zakazs");
        }
    }
}
