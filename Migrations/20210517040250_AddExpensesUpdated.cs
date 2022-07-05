using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTrackerProject.Migrations
{
    public partial class AddExpensesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Expenses",
                newName: "ExpenseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseName",
                table: "Expenses",
                newName: "ItemName");
        }
    }
}
