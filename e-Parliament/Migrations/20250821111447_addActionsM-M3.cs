using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class addActionsMM3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "account_type_actions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_account_type_actions_ActionId",
                table: "account_type_actions",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_actions_ActionId",
                table: "account_type_actions",
                column: "ActionId",
                principalTable: "actions",
                principalColumn: "action_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_actions_ActionId",
                table: "account_type_actions");

            migrationBuilder.DropIndex(
                name: "IX_account_type_actions_ActionId",
                table: "account_type_actions");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "account_type_actions");
        }
    }
}
