using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMeal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodMeal",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "integer", nullable: false),
                    MealsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeal", x => new { x.FoodsId, x.MealsId });
                    table.ForeignKey(
                        name: "FK_FoodMeal_foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeal_meals_MealsId",
                        column: x => x.MealsId,
                        principalTable: "meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeal_MealsId",
                table: "FoodMeal",
                column: "MealsId");
        }
    }
}
