using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_foods_meals_MealId",
                table: "foods");

            migrationBuilder.DropIndex(
                name: "IX_foods_MealId",
                table: "foods");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "foods");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "foods",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_foods_MealId",
                table: "foods",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_foods_meals_MealId",
                table: "foods",
                column: "MealId",
                principalTable: "meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
