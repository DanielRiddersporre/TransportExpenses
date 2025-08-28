using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportExpenses.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updated_expense_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Expenses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Expenses");
        }
    }
}
