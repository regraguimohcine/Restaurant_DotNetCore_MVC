using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_DotnetCoreMvc.Migrations
{
    public partial class ShopingCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopingCards",
                columns: table => new
                {
                    ShopingCardItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PieId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopingCardId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopingCards", x => x.ShopingCardItemId);
                    table.ForeignKey(
                        name: "FK_ShopingCards_Pies_PieId",
                        column: x => x.PieId,
                        principalTable: "Pies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCards_PieId",
                table: "ShopingCards",
                column: "PieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopingCards");
        }
    }
}
