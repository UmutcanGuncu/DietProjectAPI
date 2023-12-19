using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migUpdateCarbName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Carbonhydrate",
                table: "foods",
                newName: "Carb");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Carb",
                table: "foods",
                newName: "Carbonhydrate");
        }
    }
}
