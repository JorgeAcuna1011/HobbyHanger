using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.HobbyHanger.Migrations
{
    /// <inheritdoc />
    public partial class Fixedanerrorinthetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Measurements_MeasurementsId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Measurements_MeasurementsId",
                table: "Products",
                column: "MeasurementsId",
                principalTable: "Measurements",
                principalColumn: "MeasurementsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Measurements_MeasurementsId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Measurements_MeasurementsId",
                table: "Products",
                column: "MeasurementsId",
                principalTable: "Measurements",
                principalColumn: "MeasurementsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
