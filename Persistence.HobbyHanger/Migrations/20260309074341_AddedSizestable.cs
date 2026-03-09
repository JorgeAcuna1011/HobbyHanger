using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.HobbyHanger.Migrations
{
    /// <inheritdoc />
    public partial class AddedSizestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberSize",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementsId",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    MeasurementsId = table.Column<string>(type: "TEXT", nullable: false),
                    LetterSize = table.Column<int>(type: "INTEGER", nullable: true),
                    WaistSize = table.Column<int>(type: "INTEGER", nullable: true),
                    InseamSize = table.Column<int>(type: "INTEGER", nullable: true),
                    MeasurementType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.MeasurementsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MeasurementsId",
                table: "Products",
                column: "MeasurementsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Measurements_MeasurementsId",
                table: "Products",
                column: "MeasurementsId",
                principalTable: "Measurements",
                principalColumn: "MeasurementsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Measurements_MeasurementsId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Products_MeasurementsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MeasurementsId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "NumberSize",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Products",
                type: "INTEGER",
                nullable: true);
        }
    }
}
