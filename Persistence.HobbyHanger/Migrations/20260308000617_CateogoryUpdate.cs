using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.HobbyHanger.Migrations
{
    /// <inheritdoc />
    public partial class CateogoryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WaistSize",
                table: "Products",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WaistSize",
                table: "Products");
        }
    }
}
