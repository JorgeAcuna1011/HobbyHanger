using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.HobbyHanger.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WaistSize",
                table: "Products",
                newName: "NumberSize");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberSize",
                table: "Products",
                newName: "WaistSize");
        }
    }
}
