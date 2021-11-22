using Microsoft.EntityFrameworkCore.Migrations;

namespace demoNetCore.Migrations
{
    public partial class tes1_tes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tes1s",
                columns: table => new
                {
                    tes1ID = table.Column<string>(type: "TEXT", nullable: false),
                    tes1Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tes1s", x => x.tes1ID);
                });

            migrationBuilder.CreateTable(
                name: "tes2s",
                columns: table => new
                {
                    ProducttID = table.Column<string>(type: "TEXT", nullable: false),
                    ProducttName = table.Column<string>(type: "TEXT", nullable: true),
                    UnitPrice = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<string>(type: "TEXT", nullable: true),
                    tes1ID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tes2s", x => x.ProducttID);
                    table.ForeignKey(
                        name: "FK_tes2s_tes1s_tes1ID",
                        column: x => x.tes1ID,
                        principalTable: "tes1s",
                        principalColumn: "tes1ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tes2s_tes1ID",
                table: "tes2s",
                column: "tes1ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tes2s");

            migrationBuilder.DropTable(
                name: "tes1s");
        }
    }
}
