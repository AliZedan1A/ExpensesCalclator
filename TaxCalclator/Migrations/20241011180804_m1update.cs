using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxCalclator.Migrations
{
    /// <inheritdoc />
    public partial class m1update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reson",
                table: "Expenses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reson",
                table: "Expenses");
        }
    }
}
