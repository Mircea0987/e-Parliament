using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Parliament.Migrations
{
    /// <inheritdoc />
    public partial class addActionsMM4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_account_types_AccountTypeId",
                table: "account_type_actions");

            migrationBuilder.DropColumn(
                name: "actions",
                table: "account_types");

            migrationBuilder.RenameColumn(
                name: "AccountTypeId",
                table: "account_type_actions",
                newName: "accountTypeId");

            migrationBuilder.RenameColumn(
                name: "IdAction",
                table: "account_type_actions",
                newName: "action_id");

            migrationBuilder.RenameColumn(
                name: "IdAccountType",
                table: "account_type_actions",
                newName: "account_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_account_type_actions_AccountTypeId",
                table: "account_type_actions",
                newName: "IX_account_type_actions_accountTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "accountTypeId",
                table: "account_type_actions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_account_types_accountTypeId",
                table: "account_type_actions",
                column: "accountTypeId",
                principalTable: "account_types",
                principalColumn: "account_type_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_type_actions_account_types_accountTypeId",
                table: "account_type_actions");

            migrationBuilder.RenameColumn(
                name: "accountTypeId",
                table: "account_type_actions",
                newName: "AccountTypeId");

            migrationBuilder.RenameColumn(
                name: "action_id",
                table: "account_type_actions",
                newName: "IdAction");

            migrationBuilder.RenameColumn(
                name: "account_type_id",
                table: "account_type_actions",
                newName: "IdAccountType");

            migrationBuilder.RenameIndex(
                name: "IX_account_type_actions_accountTypeId",
                table: "account_type_actions",
                newName: "IX_account_type_actions_AccountTypeId");

            migrationBuilder.AddColumn<string>(
                name: "actions",
                table: "account_types",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "AccountTypeId",
                table: "account_type_actions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_account_type_actions_account_types_AccountTypeId",
                table: "account_type_actions",
                column: "AccountTypeId",
                principalTable: "account_types",
                principalColumn: "account_type_id");
        }
    }
}
