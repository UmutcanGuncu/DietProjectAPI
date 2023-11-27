using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "meals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_meals_AppUserId",
                table: "meals",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_meals_AspNetUsers_AppUserId",
                table: "meals",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meals_AspNetUsers_AppUserId",
                table: "meals");

            migrationBuilder.DropIndex(
                name: "IX_meals_AppUserId",
                table: "meals");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "meals");
        }
    }
}
