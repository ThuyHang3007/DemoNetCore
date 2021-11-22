using Microsoft.EntityFrameworkCore.Migrations;

namespace demoNetCore.Migrations
{
    public partial class demokethua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "demokethuaID",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "demokethuatName",
                table: "Person",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "demokethuaID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "demokethuatName",
                table: "Person");
        }
    }
}
