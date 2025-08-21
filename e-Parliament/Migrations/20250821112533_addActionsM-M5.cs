using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class addActionsMM5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_account_types_accountTypeId",
                table: "account_type_actions");

            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_actions_ActionId",
                table: "account_type_actions");

            migrationBuilder.DropIndex(
                name: "IX_account_type_actions_accountTypeId",
                table: "account_type_actions");

            migrationBuilder.DropIndex(
                name: "IX_account_type_actions_ActionId",
                table: "account_type_actions");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "account_type_actions");

            migrationBuilder.DropColumn(
                name: "accountTypeId",
                table: "account_type_actions");

            migrationBuilder.CreateIndex(
                name: "IX_account_type_actions_action_id",
                table: "account_type_actions",
                column: "action_id");

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_account_types_account_type_id",
                table: "account_type_actions",
                column: "account_type_id",
                principalTable: "account_types",
                principalColumn: "account_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_actions_action_id",
                table: "account_type_actions",
                column: "action_id",
                principalTable: "actions",
                principalColumn: "action_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_account_types_account_type_id",
                table: "account_type_actions");

            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_actions_action_id",
                table: "account_type_actions");

            migrationBuilder.DropIndex(
                name: "IX_account_type_actions_action_id",
                table: "account_type_actions");

            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "account_type_actions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "accountTypeId",
                table: "account_type_actions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_account_type_actions_accountTypeId",
                table: "account_type_actions",
                column: "accountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_account_type_actions_ActionId",
                table: "account_type_actions",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_account_types_accountTypeId",
                table: "account_type_actions",
                column: "accountTypeId",
                principalTable: "account_types",
                principalColumn: "account_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_actions_ActionId",
                table: "account_type_actions",
                column: "ActionId",
                principalTable: "actions",
                principalColumn: "action_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
